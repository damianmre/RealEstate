namespace RealEstate.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Size { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
