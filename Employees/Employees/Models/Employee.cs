using System.ComponentModel.DataAnnotations;

namespace Employees.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]  //annotation
        public string Name { get; set; }
    }
}
