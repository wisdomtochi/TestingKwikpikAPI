using TestingKwikpikAPI.Domain.Entities.Wallet;

namespace TestingKwikpikAPI.Application.Interfaces
{
    public interface IWalletAPI
    {
        Task<Wallet> GetWalletDetails();
    }
}
