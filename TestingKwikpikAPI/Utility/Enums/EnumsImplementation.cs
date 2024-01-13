namespace TestingKwikpikAPI.Utility.Enums
{
    public class EnumsImplementation
    {
        public string ConfirmationMessage(Enums enums)
        {
            return enums switch
            {
                Enums.DispatchRequestCreated => "Dispatch Request Created",
                _ => "Try again",
            };
        }
    }
}