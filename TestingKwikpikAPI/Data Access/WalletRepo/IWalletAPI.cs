using TestingKwikpikAPI.DTO.Wallet;

namespace TestingKwikpikAPI.Data_Access.WalletRepo
{
    public interface IWalletAPI
    {
        Task<WalletDTO> GetWalletDetails();
    }
}
