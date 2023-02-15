using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineAssetModels.Models
{
    public class Klingelnberg
    {
        [Required]
        private string? Machinename { get; }
        [Required]
        private string? Assetname { get; }
        private string? Series { get; }


    }
}
