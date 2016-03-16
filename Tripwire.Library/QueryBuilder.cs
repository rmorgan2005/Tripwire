using System.Collections.Generic;
using System.Linq;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace Tripwire.Library
{
    public static class QueryBuilder
    {
        public static string Build(ILayer pLayer, SelectionCriteria criteria, IList<GpsParameter> parameterList, SelectionCriteriaChoices selectionChoice)
        {
            var criteriaList = new List<string>();

            if (!string.IsNullOrWhiteSpace(criteria.JobOrderNumber))
                criteriaList.Add(string.Format("GPS_JOBORDERNUMBER LIKE '{0}%'", criteria.JobOrderNumber));

            if (criteria.QaStatus > 0)
                criteriaList.Add(string.Format("QASTATUS = {0}", criteria.QaStatus));

            if (!string.IsNullOrWhiteSpace(criteria.State))
                criteriaList.Add(string.Format("GPS_STATE = '{0}'", criteria.State));

            if (!string.IsNullOrWhiteSpace(criteria.VendorFolder))
                criteriaList.Add(string.Format("VENDOR_FOLDER LIKE '%{0}%'", criteria.VendorFolder));

            if (parameterList == null || parameterList.Count == 0 || selectionChoice == SelectionCriteriaChoices.IgnoreTolerance)
                return string.Join(" AND ", criteriaList);

            var notString = selectionChoice == SelectionCriteriaChoices.WithinTolerance ? string.Empty : "NOT";
            var toleranceList = new List<string>();

            IFeatureLayer featureLayer = (IFeatureLayer)pLayer;
            IFeatureClass pFeatureClass = featureLayer.FeatureClass;
            IFields pFields = pFeatureClass.Fields;

            foreach (var gpsParameter in parameterList)
            {
                if (pFields.FindField(gpsParameter.Field) < 0)
                    continue;

                switch (gpsParameter.ParameterType)
                {
                    case GpsParameter.GpsParameterType.List:
                        toleranceList.Add(string.Format("{0} {2} IN ({1})", gpsParameter.Field, gpsParameter.Criteria, notString));
                        break;
                    case GpsParameter.GpsParameterType.Number:
                        toleranceList.Add(string.Format("{3}({0} {1} {2})", gpsParameter.Field, gpsParameter.Operator,
                            gpsParameter.Criteria, notString));
                        break;
                    case GpsParameter.GpsParameterType.String:
                        toleranceList.Add(string.Format("{3}({0} {1} '{2}')", gpsParameter.Field, gpsParameter.Operator,
                            gpsParameter.Criteria, notString));
                        break;
                }

            }

            if (selectionChoice == SelectionCriteriaChoices.WithinTolerance)
                return string.Join(" AND ", criteriaList.Concat(toleranceList));

            // outside of tolerance, add CHPO as an AND - thus to criteriaList.
            if (selectionChoice == SelectionCriteriaChoices.OutsideToleranceWithChpo)
                criteriaList.Add(string.Format("({0} {1} '{2}')", "POINT_RAWCODE", "LIKE", "%CHPO%"));

            var toleranceOr = string.Join(" OR ", toleranceList);

            return string.Concat(string.Join(" AND ", criteriaList), " AND (", toleranceOr, ")");

        }
    }
}
