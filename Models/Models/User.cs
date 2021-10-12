using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestApp4.Models.Base;

namespace TestApp4.Models
{
    public class User : Entity
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
