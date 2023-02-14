using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Machine_assest.Models
{
    /// <summary>
    ///Klingelnberg class with properties
    /// </summary>
    public class Klingelnberg
    {
        [Required]
        private string? Machinename { get; }
        [Required]
        private string? Assetname { get; }
        private string? Series { get; }
       
       
    }
}
