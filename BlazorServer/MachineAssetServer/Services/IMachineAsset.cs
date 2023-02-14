using Machine_assest.Models;

namespace MachineAssetServer.Services
{
    public interface IMachineAsset
    {
        Task<IEnumerable<Klingelnberg>> GetListOfMachines(string Assetname);
        Task<IEnumerable<Klingelnberg>> GetListOfAssets(string Machinename);
        Task<IEnumerable<Klingelnberg>> MachineWithAllLatestSeries();
    }
}
