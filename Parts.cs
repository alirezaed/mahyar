namespace ServicesReviewApp.Models
{
    public class Parts
    {
        public int PartId { get; set; }
        public string PartTitle { get; set; }
        public int Price { get; set; }
        public ICollection<ServicesDetails> servicesDetails { get; set; }
    }
}
