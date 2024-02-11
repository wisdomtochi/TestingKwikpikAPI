using TestingKwikpikAPI.Domain.Entities.Error;

namespace TestingKwikpikAPI.Application.ErrorRepo
{
    public static class ErrorAPI
    {
        public static Error GetErrorMessage(string error)
        {
            Error errors = new()
            {
                error = error
            };

            return errors;
        }
    }
}
