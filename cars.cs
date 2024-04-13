namespace ServicesReviewApp.Models
{
    public class cars
    {
        public int CarId { get; set; }
        public string CarTitle { get; set; }
        public string ChassisNumber { get; set; }
        public int PlatsNumber { get; set; }
        public ICollection<Services> services { get; set; }

    }
}
