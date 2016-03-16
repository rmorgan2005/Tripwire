namespace Tripwire.Library
{
    public class GpsParameter
    {
        public enum GpsParameterType
        {
            String,
            Number,
            List
        }
        public string Field { get; set; }
        public string Operator { get; set; }
        public string Criteria { get; set; }
        public GpsParameterType ParameterType { get; set; }

    }
}
