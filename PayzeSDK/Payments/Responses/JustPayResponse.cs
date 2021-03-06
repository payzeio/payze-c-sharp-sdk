using System;
using PayzeSDK.Payments.Abstractions;

namespace PayzeSDK.Payments.Responses
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class JustPayResponse : PaymentResponse
    {
        public string TransactionUrl { get; private set; }

        public string TransactionId { get; private set; }

        public JustPayResponse Response
        {
            set
            {
                TransactionUrl = value.TransactionUrl;
                TransactionId = value.TransactionId;
            }
        }
    }
}