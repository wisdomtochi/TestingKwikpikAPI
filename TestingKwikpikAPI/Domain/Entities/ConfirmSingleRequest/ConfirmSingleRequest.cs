namespace TestingKwikpikAPI.Domain.Entities.ConfirmSingleRequest
{
    public class ConfirmSingleRequest
    {
        public Result result { get; set; }
    }

    public class Result
    {
        public string data { get; set; }
        public string type { get; set; }
        public string id { get; set; }
    }

}
