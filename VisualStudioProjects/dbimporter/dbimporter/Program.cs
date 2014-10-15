using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace dbimporter
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            string database = "paperDB";
            string uid = "richard";
            string password = "onlyone";


            DBConnect myConnection = new DBConnect(server,database,uid,password);

            List<string> dbSchema = myConnection.getTableSchema("Branch");

            foreach (string item in dbSchema)
            {
                Console.WriteLine(item);
            }





            /*
            for (int r = 0; r < dbSchema.Rows.Count; r++)
            {

                for (int c = 0; c < dbSchema.Columns.Count; c++)
                {
                    Console.Write(dbSchema.Rows[r][c]);
                }

                Console.WriteLine();


            }
            List<string[]> dataList = new List<string[]>();
            

            using (var textReader = new CSVreader("branch.csv"))
            {
                dataList = textReader.Data;
                
            }
            
            Console.WriteLine(dataList[1][1]);
            */


            Console.ReadLine();
        }
    }
}
