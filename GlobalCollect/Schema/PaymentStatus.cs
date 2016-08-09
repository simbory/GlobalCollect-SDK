namespace GlobalCollect.Schema
{
    public struct PaymentStatus
    {
        public static readonly string ACCOUNT_VERIFIED = "ACCOUNT_VERIFIED";
        public static readonly string CREATED = "CREATED";
        public static readonly string REDIRECTED = "REDIRECTED";
        public static readonly string PENDING_PAYMENT = "PENDING_PAYMENT";
        public static readonly string PENDING_FRAUD_APPROVAL = "PENDING_FRAUD_APPROVAL";
        public static readonly string PENDING_APPROVAL = "PENDING_APPROVAL";
        public static readonly string REJECTED = "REJECTED";
        public static readonly string AUTHORIZATION_REQUESTED = "AUTHORIZATION_REQUESTED";
        public static readonly string CAPTURE_REQUESTED = "CAPTURE_REQUESTED";
        public static readonly string CAPTURED = "CAPTURED";
        public static readonly string PAID = "PAID";
        public static readonly string CANCELLED = "CANCELLED";
        public static readonly string REJECTED_CAPTURE = "REJECTED_CAPTURE";
        public static readonly string REVERSED = "REVERSED";
        public static readonly string CHARGEBACKED = "CHARGEBACKED";
        public static readonly string REFUND_REQUESTED = "REFUND_REQUESTED";
        public static readonly string REFUNDED = "REFUNDED";
    }
}
