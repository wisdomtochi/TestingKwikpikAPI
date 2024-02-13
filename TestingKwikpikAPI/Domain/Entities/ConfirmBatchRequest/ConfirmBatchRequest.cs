namespace TestingKwikpikAPI.Domain.Entities.BatchRequestConfirmation
{
    public class ConfirmBatchRequest
    {
        public Result[] result { get; set; }
    }

    public class Result
    {
        public string data { get; set; }
    }
}
