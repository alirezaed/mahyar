namespace ServicesReviewApp.Models
{
    public class Services
    {
        public int ServiceNumber { get; set; }
        public string ServiceTitle{ get; set; }
        public DateTime ServiceDate { get; set; }
        public int Wage { get; set; }
        public customers CustomerId { get; set; }
        //public customers Customers { get; set; }
        public cars CarId { get; set; }
        // public cars car { get; set; }
        public ICollection<ServicesDetails> servicesDetails { get; set; }
    }
}
