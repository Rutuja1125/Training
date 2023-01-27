using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Collections;
using Machine_assest.Models;
using Machine_assest.Contracts;

namespace Machine_assest.Controllers
{
    [Route("api/Asset")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        public readonly IDatabaseService _databaseService;
        public readonly DataTable _dataTable;
        public AssetsController(IDatabaseService databaseService) 
        {
            _databaseService= databaseService;
            _dataTable=_databaseService.CreateDataTable();
        }

        [HttpGet("asset-name/{Assetname}")]
        public IEnumerable GetListOfMachines(string Assetname)
        {
            var Machinelist = from Datafromtxtfile in _dataTable.AsEnumerable() where Datafromtxtfile.Field<string>("Column1") == Assetname select Datafromtxtfile.Field<string>("Column0");

            return Machinelist;

        }
      
    }
} 
 