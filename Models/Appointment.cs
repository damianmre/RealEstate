namespace RealEstate.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentTime { get; set; }

        public Property Property { get; set; }
    }
}
