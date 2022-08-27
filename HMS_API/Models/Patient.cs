using System;
using System.Collections;
using System.Collections.Generic;

namespace HMS_API.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string Illness { get; set; }
    }
}
