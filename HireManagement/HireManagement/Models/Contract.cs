using System;
using System.Collections.Generic;
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
        public ICollection<Recruitment> Recruitments { get; set; }
    }
}
