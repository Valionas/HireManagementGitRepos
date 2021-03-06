﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
    public class Worker
    {   
        public int WorkerID { get; set; }
        [Required]
        [MaxLength(40)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(40)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("[0-9]{1,3}", ErrorMessage = "Your age must be between 18-100 years")]
        public int Age { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        [Required]
       
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string EmployedOnPosition { get; set; }
        [Required]
        public DateTime JoinedDate { get; set; }

        public string UserID { get;set; }
  
    }
}
