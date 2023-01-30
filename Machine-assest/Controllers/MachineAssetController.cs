using Microsoft.AspNetCore.Mvc;
using System.Data;
using Machine_assest.Services;

namespace Machine_assest.Controllers
{
    [Route("api/MachineAsset")]
    [ApiController]
    public class MachineAssetController : ControllerBase
    {
        public readonly IMachineAssetRepository _machineAssetRepository;
        public readonly DataTable _dataTable;
        public MachineAssetController(IMachineAssetRepository databaseService)
        {
            _machineAssetRepository = databaseService;
            _dataTable = _machineAssetRepository.CreateDataTable();
        }

        [HttpGet("asset-name/{Assetname}")]
        public IActionResult GetListOfMachines(string Assetname)
        {
            var assetFromRepo = _machineAssetRepository.GetListOfMachines(Assetname);
            return Ok(assetFromRepo);
        }

        [HttpGet("machine-name/{Machinename}")]
        public IActionResult GetListOfAssets(string Machinename)
        {
            var machineFromRepo = _machineAssetRepository.GetListOfAssets(Machinename);
            return Ok(machineFromRepo);
        }
        [HttpGet]
        public string MachineWithAllLatestSeries()
        {
            var lateseriesFromRepo = _machineAssetRepository.MachineWithAllLatestSeries();
            return lateseriesFromRepo;
        }
    }
}
