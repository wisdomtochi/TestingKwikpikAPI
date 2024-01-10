namespace TestingKwikpikAPI.Domains
{
    public class Wallet
    {
        public string id { get; set; }
        public string userId { get; set; }
        public int balance { get; set; }
        public int bookBalance { get; set; }
        public string currency { get; set; }
        public Extrawallets extraWallets { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }

    public class Extrawallets
    {
    }
}
