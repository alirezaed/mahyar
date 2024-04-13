namespace ServicesReviewApp.Models
{
    public class customers
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Services> services { get; set; }

    }
}
