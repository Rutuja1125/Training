using System.Data;
using System.Collections;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;
using System.Collections.Generic;

namespace Machine_assest.Services
{
    /// <summary>
    /// Defining methods in MachineAssetRepository
    /// </summary>
    public class MachineAssetRepository : IMachineAssetRepository
    {
        /// <summary>
        /// Datatable field _dataTable
        /// </summary>
        /// 
        public readonly DataTable _dataTable;

        /// <summary>
        /// constructor of class MachineAssetRepository containing return value of CreateDatatable()
        /// </summary>
        /// 
        public MachineAssetRepository()
        {
            _dataTable = CreateDataTable();
        }

        /// <summary>
        /// Grabs txt data ,stores in mongodb and creates datatable.
        /// </summary>
        public DataTable CreateDataTable()
        {
            string txtFilePath = @"C:\Users\kurh_rut\Desktop\C_Sharp_tutorials\Machine-assest\Resource\file.txt";
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Machineasset");
            var collection = database.GetCollection<BsonDocument>("information");
            long countOfcollection = collection.CountDocuments(new BsonDocument());
            string[] lines = System.IO.File.ReadAllLines(txtFilePath);
            List<BsonDocument> listOfBsonDoc = new List<BsonDocument>();
            if (countOfcollection < lines.Count())
            {
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    listOfBsonDoc.Add(new BsonDocument
            {
                { "Machine", parts[0] },
                { "Asset", parts[1] },
               {"Series", parts[2] }
            });

                }             
                collection.InsertMany(listOfBsonDoc);

            }

            List<BsonDocument> retrieveBsonDoc = collection.Find(new BsonDocument()).ToList();

            BsonDocument firstDocument = retrieveBsonDoc[0];
            DataTable dt = new DataTable("Datafromdb");
            foreach (BsonElement element in firstDocument)
            {
                dt.Columns.Add(element.Name);
            }

            foreach (BsonDocument singledoc in retrieveBsonDoc)
            {
                var row = dt.NewRow();
                foreach (BsonElement singlecollection in singledoc)
                {
                    row[singlecollection.Name] = singlecollection.Value;
                }
                dt.Rows.Add(row);
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
            var Machinelist = from Datafromdb in _dataTable.AsEnumerable() where Datafromdb.Field<string>("Asset") == Assetname select Datafromdb.Field<string>("Machine");

            return Machinelist;

        }

        /// <summary>
        ///  Get asset name by machine name
        /// </summary>
        /// <param name="Machinename"> Machine name of asset you want to get</param>
        /// <returns>list of asset names for entered machine name. </returns>
        public IEnumerable GetListOfAssets(string Machinename)
        {
            var Assestlist = from Datafromdb in _dataTable.AsEnumerable() where Datafromdb.Field<string>("Machine") == Machinename.ToString() select Datafromdb.Field<string>("Asset");

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
            var AssestsFromColumn1 = from Datafromdb in _dataTable.AsEnumerable() select Datafromdb.Field<string>("Asset");

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
                var latestseriesmachine = from Datafromdb in _dataTable.AsEnumerable() where Datafromdb.Field<string>("Asset") == singleasset orderby Datafromdb.Field<string>("Series") descending select Datafromdb.Field<string>("Machine");

                //First element from Latestseriesmachine will have latest series
                string firstelement = latestseriesmachine.First();
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
