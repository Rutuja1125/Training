using System.Collections;
using System.Data;

namespace Machine_assest.Services
{
    /// <summary>
    /// IMachineAssetRepository interface containing methods to create datatable, provides list of machines, list of assets, machine having latest series.
    /// </summary>
    public interface IMachineAssetRepository
    {
        /// <summary>
        ///Create a datatable 
        /// </summary>
        /// <returns>Grabs value from file.txt and store it in desired column of data</returns>
        DataTable CreateDataTable();

        /// <summary>
        /// Get a list of machine names for entered asset name.
        /// </summary>
        /// <param name="Assetname">Asset name of the machine you want to get</param>
        /// <returns>list of machine names for entered asset name.</returns>
        IEnumerable GetListOfMachines(string Assetname);

        /// <summary>
        /// Get asset name by machine name
        /// </summary>
        /// <param name="Machinename">Machine name of asset you want to get</param>
        /// <returns>list of asset names for entered machine name.</returns>
        IEnumerable GetListOfAssets(string Machinename);

        /// <summary>
        ///  Get machine name having latest series
        /// </summary>
        /// <returns>Machine name with maximum latest series</returns>
        string MachineWithAllLatestSeries();
    }
}
