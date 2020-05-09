using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HireManagement.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required(ErrorMessage = "Role already in the database")]
        public string RoleName { get; set; }
    }
}
