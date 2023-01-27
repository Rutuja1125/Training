using Machine_assest.Contracts;
using System.Data;

namespace Machine_assest.Services
{
    public class DatabaseService : IDatabaseService
    {
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
    }
}
