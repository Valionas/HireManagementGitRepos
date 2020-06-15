using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
 
    public class Contract
    {
        public int ContractID { get; set; }
        [Required]
        [MaxLength(40)]
        public string ContractName { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        [RegularExpression("[0-9]{1,100000}", ErrorMessage = "Insert a valid sum")]
        public double Reward { get; set; }
        [Required]
        [MaxLength(200)]
        
        public string Information { get; set; }

        public string Preference { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string EmployerEmail { get; set; }
        public string UserID { get; set; }
    
    }
}
