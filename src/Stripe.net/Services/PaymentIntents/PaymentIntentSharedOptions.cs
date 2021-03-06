namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentSharedOptions : BaseOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("on_behalf_of")]
        public string OnBehalfOf { get; set; }

        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        [JsonProperty("receipt_email")]
        public string ReceiptEmail { get; set; }

        [JsonProperty("save_payment_method")]
        public bool? SavePaymentMethod { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        [JsonProperty("transfer_data")]
        public PaymentIntentTransferDataOptions TransferData { get; set; }

        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }

        [Obsolete("Use PaymentMethodTypes")]
        [JsonProperty("allowed_source_types")]
        public List<string> AllowedSourceTypes { get; set; }
    }
}
