namespace ServicesReviewApp.Models
{
    public class ServicesDetails
    {
        public int ServiceNumber { get; set; }
        
        public int PartId { get; set; }
        /*public int Wage { get; set; }
        public int Price { get; set; }
        */
        public Services Wage { get; set; }
        public Parts Price { get; set; }
        public Services Services { get; set; }
        public Parts Parts { get; set; }
        
        public ServiceType ServiceTypeID { get; set; }
    }
}
