namespace MachineAssetServer.Services
{
    public class MachineAsset : IMachineAsset
    {
        private readonly HttpClient httpClient;

        public MachineAsset(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<MachineAsset>> GetListOfMachines(string Assetname)
        {
            return (IEnumerable<MachineAsset>)await httpClient.GetAsync("api/Assets/{Machinename}");
        }
    }
}

