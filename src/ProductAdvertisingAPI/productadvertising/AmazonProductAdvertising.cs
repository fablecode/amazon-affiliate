namespace productadvertising
{
    public class AmazonProductAdvertising
    {
        public AmazonProductAdvertising(IAmazonSettings settings)
        {
            
        }
    }

    public interface IAmazonSettings
    {
        string AccessKey { get; set; }
        string SecretKey { get; set; }
        string AssociateTag { get; set; }
        string EndPoint { get; set; }
    }

    public class AmazonSettings : IAmazonSettings
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string AssociateTag { get; set; }
        public string EndPoint { get; set; }
    }

    public class AmazonAuthentication
    {
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
    }
    public class AmazonAffiliate
    {
        public string EndPoint { get; set; }
        public string AssociateTag { get; set; }
    }
}