namespace KTMS.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public required int Amount { get; set; }
        public required DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; } //e.g., Credit Card, PayPal, Bank Transfer
        public required string Status { get; set; } //e.g., Completed, Pending, Failed

        //Navigation Properties
        public Application Application { get; set; }
    }
}
