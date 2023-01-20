using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; } //Guid is unique
        [Required]
        public string Name { get; set; }
        
    }
}
