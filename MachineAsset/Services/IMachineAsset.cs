
namespace MachineAssetServer.Services
{
    public interface IMachineAsset
    {
        Task<IEnumerable<MachineAsset>> GetListOfMachines(string Assetname);
        //Task<IEnumerable<MachineAsset>> GetListOfAssets(string Machinename);
        //Task<IEnumerable<MachineAsset>> MachineWithAllLatestSeries();
    }
}
