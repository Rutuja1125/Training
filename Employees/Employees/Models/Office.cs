using System.ComponentModel.DataAnnotations;

namespace Employees.Models
{
    public class Office
    {
        public int Id { get; set; }
        [Required]
        public string Location { get; set; }
        public int EmpId { get; set; }
        //navigation property
        public Employee Emp { get; set; } //Employee class object
    }
}
