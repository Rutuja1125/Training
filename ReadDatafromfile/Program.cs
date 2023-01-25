using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;
//using System.Data.DataSetExtensions;

namespace ReadDatafromfile
{
    public class Program
    {

        public static void Main()
        {
            DataTable dt = new DataTable("Data");

            TextReader tr = File.OpenText(@"C:\Users\kurh_rut\Desktop\C_Sharp_tutorials\Machine-assest\Resource\file.txt");
            string LineInFile;
            while ((LineInFile = tr.ReadLine()) != null)
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

            var result = from Data in dt.AsEnumerable() where Data.Field<string>("Column0") == "C300" select Data.Field<string>("Column1");


            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
            //Console.ReadKey();


            var result1 = from Data in dt.AsEnumerable() where Data.Field<string>("Column1") == " Cutter head" select Data.Field<string>("Column0");


            foreach (var row in result1)
            {
                Console.WriteLine(row);
            }
            List<string> AssetNames = new List<string>();
            var result3 = from Data in dt.AsEnumerable() select Data.Field<string>("Column1");
            foreach (var row in result3)
            {
                if (!AssetNames.Contains(row))
                {
                    AssetNames.Add(row);
                }
            }
            foreach (var item in AssetNames)
            {
                var result2 = from Data in dt.AsEnumerable() where Data.Field<string>("Column1") == item orderby Data.Field<string>("Column2") descending select Data.Field<string>("Column0");
            }
            //if key present in dictionary increase the value by 1 else create a new key and assign count of value as 1
            Console.ReadKey();
        }


    }
}
