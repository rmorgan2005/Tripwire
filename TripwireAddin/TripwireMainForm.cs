using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Geodatabase;
using Tripwire.Library;


namespace TripwireAddin
{
    public partial class TripwireMainForm : Form
    {
        //private IMxDocument _mxDocument;
        private IActiveView _activeView;
        private IEditor3 _editor;
        private IMap _map;
        private IList<GpsParameter> _gpsParameters;

        private readonly GpsParametersForm _frmGpsParameters;

        public TripwireMainForm()
        {
            InitializeComponent();
            cmboQAStatus.DataSource = new BindingSource(GpsDictionaries.QaStatusDictionary, null);
            cmboQAStatus.DisplayMember = "Value";
            cmboQAStatus.ValueMember = "Key";
            cmboQAStatus.SelectedValue = 200;

            cmboState.Items.Add(string.Empty);
            cmboState.Items.Add("OH");
            cmboState.Items.Add("PA");
            cmboState.Items.Add("VA");
            cmboState.SelectedIndex = 0;

            rdoInsideTolerance.Checked = true;

            _frmGpsParameters = new GpsParametersForm();
            _gpsParameters = GpsDictionaries.DefaultGpsParameters;
        }

        public void Show(IMxDocument mxDocument, IEditor3 editor)
        {
            //_mxDocument = mxDocument;
            _activeView = mxDocument.ActivatedView;
            _editor = editor;
            _map = mxDocument.FocusMap;
            // IEnvelope envelope = activeView.Extent;
            Show();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtMessage.Refresh();
            Application.DoEvents();

            var layers = Utilities.GetGpsFeatureLayers(_map);

            foreach (var layer in layers)
            {
                Utilities.ClearSelectedMapFeatures(_activeView, (IFeatureLayer)layer);
            }
            foreach (var layer in layers)
            {
                var whereClause = QueryBuilder.Build(layer, PopulateSelectionCriteria(), _gpsParameters, GetSelectedCriteriaRadioButton());
                var count = Utilities.SelectMapFeaturesByAttributeQuery(_activeView, (IFeatureLayer)layer, whereClause);
                txtMessage.AppendText(string.Concat(layer.Name, ": ", count, "\r\n"));

                if ((chkAcceptWithin.Enabled && chkAcceptWithin.Checked) || (chkAcceptChpo.Enabled && chkAcceptChpo.Checked))
                {
                    if (Utilities.IsInEditSession(_editor))
                    {
                        ChangeQaStatus((IFeatureLayer)layer, 500);
                    }
                    else
                    {
                        txtMessage.AppendText("Not in Edit Session! No changes made...\r\n");
                    }
                }
            }

            txtMessage.AppendText("\r\nDone!");
        }

        private SelectionCriteriaChoices GetSelectedCriteriaRadioButton()
        {
            if (rdoInsideTolerance.Checked)
                return SelectionCriteriaChoices.WithinTolerance;
            if (rdoIgnoreTolerance.Checked)
                return SelectionCriteriaChoices.IgnoreTolerance;
            if (rdoOutsideTolerance.Checked)
                return SelectionCriteriaChoices.OutsideTolerance;

            return SelectionCriteriaChoices.OutsideToleranceWithChpo;

        }

        private void ChangeQaStatus(IFeatureLayer layer, int qaStatus)
        {
            IFeatureSelection featureSelection = (IFeatureSelection)layer;
            ISelectionSet selectionSet = featureSelection.SelectionSet;
            ICursor cursor;
            selectionSet.Search(null, false, out cursor);
            IFeatureCursor featureCursor = (IFeatureCursor)cursor;
            IFeature feature = featureCursor.NextFeature();
            var qaStatusIndex = feature == null ? -1 : feature.Fields.FindField("QASTATUS");
            if (qaStatusIndex >= 0)
            {
                while (feature != null)
                {
                    feature.Value[qaStatusIndex] = qaStatus;
                    feature.Store();
                    feature = featureCursor.NextFeature();
                }
            }

            System.Runtime.InteropServices.Marshal.ReleaseComObject(cursor);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(featureCursor);
        }

        private SelectionCriteria PopulateSelectionCriteria()
        {
            return new SelectionCriteria
            {
                JobOrderNumber = txtJONum.Text,
                QaStatus = (int)cmboQAStatus.SelectedValue,
                State = cmboState.Text,
                VendorFolder = txtVendorFolder.Text
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGpsParameters_Click(object sender, EventArgs e)
        {
            var dlgResult = _frmGpsParameters.ShowDialog(_gpsParameters);
            if (dlgResult == DialogResult.OK)
                _gpsParameters = _frmGpsParameters.UpdateParameters();

        }

        private void rdoInsideTolerance_CheckedChanged(object sender, EventArgs e)
        {
            chkAcceptWithin.Enabled = rdoInsideTolerance.Checked;
        }

        private void rdoOutsideChpo_CheckedChanged(object sender, EventArgs e)
        {
            chkAcceptChpo.Enabled = rdoOutsideChpo.Checked;
        }
    }
}
