namespace TestingKwikpikAPI.DTO.ConfirmSingleRequest
{
    public class ConfirmSingleRequestDTO
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
