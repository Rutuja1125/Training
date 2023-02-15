
using Newtonsoft.Json;

namespace MachineAssetServer.Services
{
    public class MachineAsset : IMachineAsset
    {
        private readonly HttpClient httpClient;

        public MachineAsset(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<string>> GetListOfMachines(string Assetname)
        {
            var result = await httpClient.GetAsync($"api/Machines/{Assetname}");
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<List<string>>(result1);
            return display;

            
        }

        public async Task<List<string>> GetListOfAssets(string Machinename)
        {
            var result = await httpClient.GetAsync($"api/Assets/{Machinename}");
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<List<string>>(result1);
           
            return display;
        }

        public async Task<string> MachineWithAllLatestSeries()
        {
            var result = await httpClient.GetAsync($"api/Series");
            var result1 = await result.Content.ReadAsStringAsync();
          //  var display = JsonConvert.DeserializeObject<string>(result1);
            return result1;
        }
    }
}

