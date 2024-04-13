namespace ServicesReviewApp.Models
{
    public class ServiceType
    {
        public int ServiceTypeID { get; set; }
        public string ServiceTypeTitle { get; set; }
        public ICollection<ServicesDetails> servicesDetails { get; set; }
    }
}
