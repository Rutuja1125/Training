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
            foreach (var document1 in result)
            {
                Console.WriteLine(document1.ToJson());
            }
            Console.ReadKey();
        }

    }
}

