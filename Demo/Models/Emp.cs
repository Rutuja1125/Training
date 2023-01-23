using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{/// <summary>
/// This is Emp class
/// </summary>
    public class Emp
    {/// <summary>
    /// This is Employee Id class
    /// </summary>
        [Key]
        public int Id { get; set; } //Guid is unique

        /// <summary>
        /// This is Name of Employee
        /// </summary>
        [Required]
        public string? Name { get; set; } 
        
    }
}
