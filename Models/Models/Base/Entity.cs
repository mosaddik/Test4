using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp4.Models.Base
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [Required]
        public DateTime CreatedOn  { get; set; }
    }
}
