using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.Models
{
    public class Worker
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

        public DateTime JoinedDate { get; set; }

        public ICollection<Recruitment> Recruitments { get; set; }
    }
}
