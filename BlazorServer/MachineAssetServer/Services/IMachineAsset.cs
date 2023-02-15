using MachineAssetModels.Models;
using System.Net.NetworkInformation;

namespace MachineAssetServer.Services
{
    public interface IMachineAsset
    {
        Task<List<string>> GetListOfMachines(string Assetname);
        Task<List<string>> GetListOfAssets(string Machinename);
        Task<string> MachineWithAllLatestSeries();
    }
}
