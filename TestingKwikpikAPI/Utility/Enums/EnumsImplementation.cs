namespace TestingKwikpikAPI.Utility.Enums
{
    public class EnumsImplementation
    {
        public static string ConfirmationMessage(Enums enums)
        {
            return enums switch
            {
                Enums.DispatchRequestCreated => "Dispatch Request Created",
                Enums.BatchRequestCreated => "Batch Request Created",
                Enums.FillSomething => "Fill Something",
                _ => "Try again",
            };
        }
    }
}