using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestApp4.Models.Base;

namespace TestApp4.Models
{
    public class UserRole : Entity
    {
        [Required]
        public string RoleName { get; set; }
    }
}
