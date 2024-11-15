﻿namespace backendLab.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public int HotelID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Relationships
        public Hotel Hotel { get; set; }
        public ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
    }

}
