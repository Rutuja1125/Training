using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MongoDB.Driver;
using System.Runtime.CompilerServices;
using MongoDB.Bson;
using System.Collections.ObjectModel;
using MongoDB.Bson.Serialization;
using System.Data;

namespace jsonfiletomongodb
{

    internal class KIPL
    {

        static  void Main(string[] args)
        {
            string filePath = @"C:\Users\kurh_rut\Desktop\C_Sharp_tutorials\Machine-assest\Resource\file.txt";

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Machineasset");
            string[] lines = System.IO.File.ReadAllLines(filePath);
            List<BsonDocument> check = new List<BsonDocument>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                check.Add(new BsonDocument
            {
                { "Machine", parts[0] },
                { "Asset", parts[1] },
               {"Series", parts[2] }
            }); 
             
            }
            var collection = database.GetCollection<BsonDocument>("information");
            collection.InsertMany(check);
            var result = collection.Find(new BsonDocument()).ToList();
    
           DataTable dt = new DataTable();

            var firstDocument = result[0];
            foreach (var element in firstDocument)
            {
                dt.Columns.Add(element.Name);
            }
            foreach (var item in result)
            {
                var row = dt.NewRow();
                foreach (var element in item)
                {
                    row[element.Name] = element.Value;
                }
                dt.Rows.Add(row);
            }
            Console.ReadKey();
        }

    }
}

