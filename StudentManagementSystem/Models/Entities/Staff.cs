﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Entities
{
    public class Staff
    {
        public Staff()
        {
            this.StaffAttendances = new List<StaffAttendance>();
            this.TimeTables = new List<TimeTable>();
        }
        public int StaffId { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage ="{0} Required Field!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public int DesignationId { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public double BasicSalary { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public string Qualification { get; set; }
        public string photo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "{0} Required Field!")]
        public string HomePhone { get; set; }
        public bool DoYouHaveAnyDisability { get; set; }
        public string DisabilityDetails { get; set; }
        public bool TakingAnyMedication { get; set; }
        public string MedicationDetails { get; set; }
        public bool AnyCriminalOffence { get; set; }
        public string CriminalOffenceDetails { get; set; }
        public DateTime RegistrationDate { get; set; }

        //[NotMapped]
        //public HttpPostedFileBase PhotoFile { get; set; }
        public ICollection<StaffAttendance> StaffAttendances { get; set; }
        public ICollection<EmployeeSalary> EmployeeSalaries { get; set; }
        public ICollection<TimeTable> TimeTables { get; set; }
        public ICollection<EmployeeLeaving> EmployeeLeavings { get; set; }
        public User User { get; set; }
        public Designation Designation { get; set; }
    }
}

namespace SchoolManagementSystem
{
    class HttpPostedFileBase
    {
    }
}