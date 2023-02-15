using Microsoft.AspNetCore.Mvc;
using System.Data;
using MachineAssetModels.Models;
using Machine_assest.Services;

namespace Machine_assest.Controllers
{
    /// <summary>
    /// MachineAssetController contains method for 
    /// </summary>
    [Route("api/")]
    [ApiController]  
    public class MachineAssetController : ControllerBase
    {
        /// <summary>
        /// Instance of Interface IMachineAssetRepository
        /// </summary>
        public readonly IMachineAssetRepository _machineAssetRepository;
        /// <summary>
        /// Assign interface instance _machineAssetRepository which is a class variable to a parameter databaseService
        /// </summary>
        /// <param name="databaseService"></param>
        public MachineAssetController(IMachineAssetRepository databaseService)
        {
            _machineAssetRepository = databaseService;
         
        }
        /// <summary>
        /// Get machine name by asset name 
        /// </summary>
        /// <param name="Assetname">Asset name of the machine you want to get</param>
        /// <returns>list of machine names for entered asset name.</returns>
        [HttpGet("Machines/{Assetname}")]
        public IActionResult GetListOfMachines(string Assetname)
        {
            var assetFromRepo = _machineAssetRepository.GetListOfMachines(Assetname);
            return Ok(assetFromRepo);
        }

        /// <summary>
        /// Get asset name by machine name
        /// </summary>
        /// <param name="Machinename">Machine name of asset you want to get</param>
        /// <returns>list of asset names for entered machine name.</returns>
        [HttpGet("Assets/{Machinename}")]        
        public IActionResult GetListOfAssets(string Machinename)
        {
            var machineFromRepo = _machineAssetRepository.GetListOfAssets(Machinename);
            return Ok(machineFromRepo);
        }

        /// <summary>
        /// Get machine name having latest series
        /// </summary>
        /// <returns>Machine name with maximum latest series</returns>
        [HttpGet("Series")]
        public string MachineWithAllLatestSeries()
        {
            var lateseriesFromRepo = _machineAssetRepository.MachineWithAllLatestSeries();
            return lateseriesFromRepo;
        }
    }
}
