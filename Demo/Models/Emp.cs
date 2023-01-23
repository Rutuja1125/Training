using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Emp
    {/// <summary>
    /// This is Id  Employee class
    /// </summary>
        [Key]
        public int Id { get; set; } //Guid is unique

        /// <summary>
        /// This is Name of Employee
        /// </summary>
        [Required]
        public string Name { get; set; }
        
    }
}
