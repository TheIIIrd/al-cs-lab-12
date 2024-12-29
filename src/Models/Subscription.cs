namespace laboratory_12.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
