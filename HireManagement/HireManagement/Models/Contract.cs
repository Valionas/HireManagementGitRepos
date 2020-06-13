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
        public string ContractName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double Reward { get; set; }
        
        public string Information { get; set; }

        public string Preference { get; set; }

       
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string EmployerEmail { get; set; }
        public string UserID { get; set; }
    
    }
}
