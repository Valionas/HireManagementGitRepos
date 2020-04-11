using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
    public enum Review
    {
        Excellent,VeryGood,Good,Poor
    }
    public class Recruitment
    {
        public int RecruitmentID { get; set; }   
        public int ContractID { get; set; }
        public int WorkerID { get; set; }
        public Review? Review { get; set; }   //Optional to choose

        public Worker Worker { get; set; }
        public Contract Contract { get; set; }

    }
}
