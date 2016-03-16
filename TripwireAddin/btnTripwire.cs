using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Editor;

namespace TripwireAddin
{
    public class btnTripwire : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        TripwireMainForm _mainForm;

        public btnTripwire()
        {
        }

        protected override void OnClick()
        {
            //  Sample code showing how to access button host
            //ArcMap.Application.CurrentTool = null;

            IMxDocument mxdoc = ArcMap.Application.Document as IMxDocument;
            IEditor3 editor = ArcMap.Editor;


            if (_mainForm == null)
                _mainForm = new TripwireMainForm();
            _mainForm.Show(mxdoc, editor);
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
