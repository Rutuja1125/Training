using Machine_assest.Models;
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
        public async Task<IEnumerable<Klingelnberg>> GetListOfMachines(string Assetname)
        {
            var result = await httpClient.GetAsync($"api/Machines/{Assetname}");
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<IEnumerable<Klingelnberg>>(result1);
            return display;
        }

        public async Task<IEnumerable<Klingelnberg>> GetListOfAssets(string Machinename)
        {
            var result = await httpClient.GetAsync($"api/Assets/{Machinename}");
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<IEnumerable<Klingelnberg>>(result1);
            return display;
        }

        public async Task<IEnumerable<Klingelnberg>> MachineWithAllLatestSeries()
        {
            var result = await httpClient.GetAsync($"api/Series");
            var result1 = await result.Content.ReadAsStringAsync();
            var display = JsonConvert.DeserializeObject<IEnumerable<Klingelnberg>>(result1);
            return display;
        }
    }
}
