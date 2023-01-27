using Machine_assest.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Collections.Generic;
using System.Collections;

namespace Machine_assest.Controllers
{
    [Route("api/Machine")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        public readonly IDatabaseService _databaseService;
        public readonly DataTable _dataTable;
        public MachineController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            _dataTable = _databaseService.CreateDataTable();
        }

        [HttpGet("{Machinename}")]

        public IEnumerable GetListOfAssets(string Machinename)
        {
            var Assestlist = from Datafromtxtfile in _dataTable.AsEnumerable() where Datafromtxtfile.Field<string>("Column0") == Machinename.ToString() select Datafromtxtfile.Field<string>("Column1");

            return Assestlist;

        }
    }
}
