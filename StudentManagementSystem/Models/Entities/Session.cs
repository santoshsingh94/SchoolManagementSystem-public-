﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models.Entities
{
    public class Session
    {
        public Session()
        {          
            this.ProgrameSessions = new List<ProgrameSession>();
            //this.Attendances = new List<Attendance>();
            this.Students = new List<Student>();
        }

        [Key]
        [Required]
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public ICollection<ProgrameSession> ProgrameSessions { get; set; }
        public ICollection<Student> Students { get; set; }
        public User User { get; set; }
    }
}
