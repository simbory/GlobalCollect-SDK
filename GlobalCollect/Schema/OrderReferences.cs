using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class OrderReferences
    {
        /// <summary>
        /// Descriptive text that is used towards to consumer, either during an online checkout at a third party and/or on the statement of the consumer. For card transactions this is usually referred to as a Soft Descriptor. The maximum allowed length varies per card acquirer: AIB - 22 characters American Express - 25 characters Atos Origin BNP - 15 characters Barclays - 25 characters Catella - 22 characters CBA - 20 characters Elavon - 25 characters First Data - 25 characters INICIS (INIPAY) - 22-30 characters JCB - 25 characters Merchant Solutions - 22-25 characters Payvision (EU &amp; HK) - 25 characters SEB Euroline - 22 characters Sub1 Argentina - 15 characters Wells Fargo - 25 characters Note that we advise you to use 22 characters as the max length as beyond this our experience is that issuers will start to truncate. For alternative payment products the maximum allowed length varies per payment product: 402 eCard Poland - 30 characters 404 INICIS - 80 characters 802 Nordea ePayment Finland - 234 characters 809 iDeal - 32 characters 819 Aktia - 210 characters 836 SOFORT - 42 characters 840 PayPal - 127 characters 841 WebMoney - 175 characters 845 CashU - 250 characters 849 Yandex - 64 characters 861 Alipay - 256 characters 880 BOKU - 20 characters 8580 Qiwi - 255 characters 1504 Konbini - 80 characters All other payment products don't support a descriptor.
        /// </summary>
        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        /// <summary>
        /// Object containing additional invoice data
        /// </summary>
        [JsonProperty("invoiceData")]
        public OrderInvoiceData InvoiceData { get; set; }

        /// <summary>
        /// Your order identifier Note: This does not need to have a unique value for each transaction. This allows your to link multiple transactions to the same logical order in your system.
        /// </summary>
        [JsonProperty("merchantOrderId")]
        public int MerchantOrderId { get; set; }

        /// <summary>
        /// Your unique reference of the transaction that is also returned in our report files. This is almost always used for your reconciliation of our report files.
        /// </summary>
        [JsonProperty("merchantReference")]
        public string MerchantReference { get; set; }
    }
}