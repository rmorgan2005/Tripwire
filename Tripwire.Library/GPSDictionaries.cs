using System.Collections.Generic;

namespace Tripwire.Library
{
    public static class GpsDictionaries
    {
        public static IDictionary<int, string> QaStatusDictionary
        {
            get
            {
                return new Dictionary<int, string>
                {
                    {0, string.Empty},
                    {100, "Raw Data"},
                    {200, "Ready for Processing"},
                    {400, "Review Required"},
                    {500, "Deliverable Accepted"},
                    {600, "Deliverable Accepted & Posted"},
                    {700, "Deliverable Rejected"},

                };

            }
        }

        public static IList<GpsParameter> DefaultGpsParameters
        {
            get
            {
                return new List<GpsParameter>
                {
                    new GpsParameter{Criteria = ".204", Field = "HORIZ_PRECISION", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = ".304", Field = "VERT_PRECISION", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = "6", Field = "PDOP", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = ".1", Field = "TILT_DISTANCE", ParameterType = GpsParameter.GpsParameterType.Number, Operator = "<="},
                    new GpsParameter{Criteria = "'NetworkRTK', 'NetworkFix', 'RTK'", Field = "SURVEY_METHOD", ParameterType = GpsParameter.GpsParameterType.List, Operator = "IN"},                    
                };
            }
        }
    }
}
