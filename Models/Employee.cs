using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManager.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public Position Position { get; set; }
    }
}
