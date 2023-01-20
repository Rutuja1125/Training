using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Demo.Models
{
    public class Office
    {
        [Key]
        public int Id { get; set; }

        [Microsoft.Build.Framework.Required]
        [MaxLength(20)]
        public string Location { get; set; }

        //Foreign Key
        [ForeignKey("EmpId")]
        public Emp Employee { get; set; }

        public int  EmpId { get; set; }
    }
}
