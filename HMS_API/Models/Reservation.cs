using System;

namespace HMS_API.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public DateTime Date { get; set; }
        public int Hour { get; set; }
        public string Time { get; set; }
    }
}
