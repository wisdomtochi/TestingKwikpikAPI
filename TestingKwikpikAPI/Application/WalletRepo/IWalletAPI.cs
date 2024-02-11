namespace TestingKwikpikAPI.Application.WalletRepo
{
    public interface IWalletAPI
    {
        Task<Wallet> GetWalletDetails();
    }
}
