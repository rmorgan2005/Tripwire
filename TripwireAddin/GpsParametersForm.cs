using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tripwire.Library;

namespace TripwireAddin
{
    public partial class GpsParametersForm : Form
    {
        //private IList<GpsParameter> _gpsParameters = new List<GpsParameter>();

        public GpsParametersForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(IList<GpsParameter> gpsParameters)
        {
            //_gpsParameters = gpsParameters;
            UpdateUI(gpsParameters);
            return ShowDialog();
        }

        private void UpdateUI(IList<GpsParameter> gpsParameters)
        {
            int index;
            if ((index = gpsParameters.ToList().FindIndex(x => x.Field == "HORIZ_PRECISION")) >= 0)
            {
                txtHPrec.Text = gpsParameters[index].Criteria;
            }
            if ((index = gpsParameters.ToList().FindIndex(x => x.Field == "VERT_PRECISION")) >= 0)
            {
                txtVPrec.Text = gpsParameters[index].Criteria;
            }
            if ((index = gpsParameters.ToList().FindIndex(x => x.Field == "PDOP")) >= 0)
            {
                txtPDOP.Text = gpsParameters[index].Criteria;
            }
            if ((index = gpsParameters.ToList().FindIndex(x => x.Field == "TILT_DISTANCE")) >= 0)
            {
                txtTilt.Text = gpsParameters[index].Criteria;
            }
        }



        public IList<GpsParameter> UpdateParameters()
        {
            return new List<GpsParameter>
                {
                    new GpsParameter{Criteria = txtHPrec.Text, Field = "HORIZ_PRECISION", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = txtVPrec.Text, Field = "VERT_PRECISION", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = txtPDOP.Text, Field = "PDOP", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = txtTilt.Text, Field = "TILT_DISTANCE", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    // this is just hard-coded for now
                    new GpsParameter{Criteria = "'NetworkRTK', 'NetworkFix', 'RTK'", Field = "SURVEY_METHOD", ParameterType = GpsParameter.GpsParameterType.List, Operator = "IN"},
                };



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

}

