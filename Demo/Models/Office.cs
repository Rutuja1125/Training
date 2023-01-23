using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Demo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Office
    {/// <summary>
    /// 
    /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Build.Framework.Required]
        [MaxLength(20)]      
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //Foreign Key
        [ForeignKey("EmpId")]
        public Emp? Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int  EmpId { get; set; }
    }
}
