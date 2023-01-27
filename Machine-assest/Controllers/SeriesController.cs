using Machine_assest.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Machine_assest.Controllers
{
    [Route("api/Series")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        public readonly IDatabaseService _databaseService;
        public readonly DataTable _dataTable;
        public SeriesController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            _dataTable = _databaseService.CreateDataTable();
        }

        [HttpGet]
        public string MachineWithAllLatestSeries()
        { //create an empty list
            List<string> AssetNames = new List<string>();

            //Query selects all assetnames from column1
            var AssestsFromColumn1 = from Data in _dataTable.AsEnumerable() select Data.Field<string>("Column1");

            //check whether each element result3 present in list. If element is not present then add in list
            foreach (var asset in AssestsFromColumn1)
            {
                if (!AssetNames.Contains(asset))
                {
                    AssetNames.Add(asset);
                }
            }
            //Take each element from list and run the query
            List<string>? MachineswithLatestseries = new List<string>();
            foreach (var singleasset in AssetNames)
            {
                var MachinewithLatestSeries = from Data in _dataTable.AsEnumerable() where Data.Field<string>("Column1") == singleasset orderby Data.Field<string>("Column2") descending select Data.Field<string>("Column0");

                string firstelement = MachinewithLatestSeries.First();
                MachineswithLatestseries.Add(firstelement);
            }
            string? MachinehavingallLatestSeries = MachineswithLatestseries.Max();
            if(MachinehavingallLatestSeries == null)
            {
                throw new ArgumentNullException(nameof(MachinehavingallLatestSeries));
            }
           return MachinehavingallLatestSeries;           
        }
    }
}
