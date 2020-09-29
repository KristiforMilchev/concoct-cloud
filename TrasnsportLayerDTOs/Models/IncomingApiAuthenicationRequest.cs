namespace TransportLayer.Models
{
    public class IncomingApiAuthenicationRequest
    {
        public string PrivateSecret { get; set; }
        public string FeatureRequest { get; set; }
    }
}