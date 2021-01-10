namespace PayzeSDK.Payments.Requests.Helpers
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Split
    {
        // ReSharper disable once InconsistentNaming
        public string IBAN { get; set; }

        public decimal SplitAmount { get; set; }

        public int PayIn { get; set; }
    }
}