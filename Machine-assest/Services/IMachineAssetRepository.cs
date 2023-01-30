using System.Collections;
using System.Data;

namespace Machine_assest.Services
{
    public interface IMachineAssetRepository
    {
        DataTable CreateDataTable();
        IEnumerable GetListOfMachines(string Assetname);
        IEnumerable GetListOfAssets(string Machinename);
        string MachineWithAllLatestSeries();
    }
}
