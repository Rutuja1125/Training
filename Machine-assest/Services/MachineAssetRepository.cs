using System.Data;
using System.Collections;

namespace Machine_assest.Services
{
    /// <summary>
    /// Defining methods in MachineAssetRepository
    /// </summary>
    public class MachineAssetRepository :IMachineAssetRepository
    {
        /// <summary>
        /// Datatable field _dataTable
        /// </summary>
        /// 
        public readonly DataTable _dataTable;

        /// <summary>
        /// constructor of class MachineAssetRepository
        /// </summary>
        /// 
        public MachineAssetRepository()
        {           
            _dataTable = CreateDataTable();
        }

        /// <summary>
        /// Creates a datatable dt and stores data from file.txt in dt in column format.
        /// </summary>
        /// <returns></returns>
        public DataTable CreateDataTable()
        {
            DataTable dt = new DataTable("Datafromtxtfile");

            TextReader Singlelinefromfile = System.IO.File.OpenText(@"C:\Users\kurh_rut\Desktop\C_Sharp_tutorials\Machine-assest\Resource\file.txt");

            string? LineInFile;
            while ((LineInFile = Singlelinefromfile.ReadLine()) != null)
            {
                string[] FileContent = LineInFile.Split(',');
                if (dt.Columns.Count == 0)
                {
                    for (int NoofColumn = 0; NoofColumn < FileContent.Length; NoofColumn++)
                    {
                        dt.Columns.Add(new DataColumn("Column" + NoofColumn, typeof(string)));
                    }
                }
                dt.Rows.Add(FileContent);

            }

            return dt;
        }

        /// <summary>
        ///  Get a list of machine names for entered asset name.
        /// </summary>
        /// <param name="Assetname"> Asset name of the machine you want to get</param>
        /// <returns>list of machine names for entered asset name. </returns>
        public IEnumerable GetListOfMachines(string Assetname)
        {
            var Machinelist = from Datafromtxtfile in _dataTable.AsEnumerable() where Datafromtxtfile.Field<string>("Column1") == Assetname select Datafromtxtfile.Field<string>("Column0");

            return Machinelist;

        }

        /// <summary>
        ///  Get asset name by machine name
        /// </summary>
        /// <param name="Machinename"> Machine name of asset you want to get</param>
        /// <returns>list of asset names for entered machine name. </returns>
        public IEnumerable GetListOfAssets(string Machinename)
        {
            var Assestlist = from Datafromtxtfile in _dataTable.AsEnumerable() where Datafromtxtfile.Field<string>("Column0") == Machinename.ToString() select Datafromtxtfile.Field<string>("Column1");

            return Assestlist;

        }

        /// <summary>
        ///  Get machine name having latest series
        /// </summary>
        /// <returns>Machine name with maximum latest series</returns>
        /// <exception cref="ArgumentNullException"> </exception>
        public string MachineWithAllLatestSeries()
        { //create an empty list AssetNames
            List<string> AssetNames = new List<string>();

            //Query selects all assetnames from column1
            var AssestsFromColumn1 = from Data in _dataTable.AsEnumerable() select Data.Field<string>("Column1");

            //check whether each element from AssestsFromColumn1 present in list AssetNames. If element is not present then add in list AssetNames
            foreach (var asset in AssestsFromColumn1)
            {
                if (!AssetNames.Contains(asset))
                {
                    AssetNames.Add(asset);
                }
            }
            //Create a emtp list to hold machine types of specific series
            List<string>? MachineswithLatestseries = new List<string>();

            //Take each element from list AssetNames and run the query
            foreach (var singleasset in AssetNames)
            {
                //query will provide machine names with latest series in descending order
                var Latestseriesmachine = from Data in _dataTable.AsEnumerable() where Data.Field<string>("Column1") == singleasset orderby Data.Field<string>("Column2") descending select Data.Field<string>("Column0");

                //First element from Latestseriesmachine will have latest series
                string firstelement = Latestseriesmachine.First();
                //Add machine name having latest series to list
                MachineswithLatestseries.Add(firstelement);
            }
            //Maximum occurrence of machine type in list
            string? MachinehavingallLatestSeries = MachineswithLatestseries.Max();
            if (MachinehavingallLatestSeries == null)
            {
                throw new ArgumentNullException(nameof(MachinehavingallLatestSeries));
            }
            return MachinehavingallLatestSeries;
        }
    }
}
