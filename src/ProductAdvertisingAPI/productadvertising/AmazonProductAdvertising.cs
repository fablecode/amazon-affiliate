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
        AmazonAuthentication Authentication { get; set; }
        AmazonAffiliate Affiliate { get; set; }
    }

    public class AmazonSettings : IAmazonSettings
    {
        public AmazonAuthentication Authentication { get; set; }
        public AmazonAffiliate Affiliate { get; set; }
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