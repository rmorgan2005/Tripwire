using System.Collections.Generic;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace Tripwire.Library
{
    public static class Utilities
    {
        public static void ClearSelectedMapFeatures(IActiveView activeView, IFeatureLayer featureLayer)
        {
            if (activeView == null || featureLayer == null)
            {
                return;
            }
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection; // Dynamic Cast

            // Invalidate only the selection cache. Flag the original selection
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, featureLayer, null);

            // Clear the selection
            featureSelection.Clear();

            // Flag the new selection
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, featureLayer, null);
        }

        public static int SelectMapFeaturesByAttributeQuery(IActiveView activeView, IFeatureLayer featureLayer, string whereClause)
        {
            if (activeView == null || featureLayer == null || whereClause == null)
            {
                return 0;
            }
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection; // Dynamic Cast

            // Set up the query
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = whereClause;

            // Invalidate only the selection cache. Flag the original selection
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, featureLayer, null);

            // Perform the selection
            featureSelection.SelectFeatures(queryFilter, esriSelectionResultEnum.esriSelectionResultNew, false);

            // Flag the new selection
            activeView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, featureLayer, null);

            return featureSelection.SelectionSet.Count;
        }

        /// <summary>
        /// Returns ILayer list starting with "GPS_" and not ending in "_Line"
        /// </summary>
        public static IList<ILayer> GetGpsFeatureLayers(IMap map)
        {
            List<ILayer> layers = new List<ILayer>();

            IEnumLayer enumLayer = map.Layers;

            ILayer layer = enumLayer.Next();
            while (layer != null)
            {

                IFeatureLayer featureLayer = layer as IFeatureLayer;
                if (featureLayer != null)
                {
                    IFeatureClass featureClass = featureLayer.FeatureClass;
                    IDataset dataset = (IDataset)featureClass;
                    if (dataset != null && dataset.BrowseName.Contains("GPS_") && !dataset.BrowseName.EndsWith("_Line"))
                    {
                        if (featureClass.ShapeType == esriGeometryType.esriGeometryPoint)
                        {
                            layers.Add(layer);
                        }
                    }                    
                }
                layer = enumLayer.Next();
            }
            return layers;
        }

        public static bool IsInEditSession(IEditor editor)  // IWorkspace workspace)
        {
            //IWorkspaceEdit2 workspaceEdit2 = (IWorkspaceEdit2)workspace;
            //return workspaceEdit2.IsInEditOperation;
            return editor.EditState == esriEditState.esriStateEditing;
        }
    }
}
