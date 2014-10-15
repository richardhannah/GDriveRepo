using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RFHGdriveLib.JSONTools
{
    public static class StaticJSONSerializer
    {
        

        private static string dataDir;


        public static string DataDir
        {
            get { return dataDir; }
            set { 
                dataDir = value;
                Directory.CreateDirectory(dataDir);           
            
            }
        }



        public static void saveJSONData(IJSONData jsonDataObj){
            string output = JsonConvert.SerializeObject(jsonDataObj);

            string filePath = dataDir + "\\" + jsonDataObj.IDString + ".json";

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(output);
            }
        }

        public static T loadJSONData<T>(string fileName){

            //CharData charToLoad = new CharData();
            string output;

            string filePath = dataDir + "\\" + fileName;

            using (StreamReader reader = new StreamReader(filePath, true))
            {
                output = reader.ReadToEnd();
            }
            T dataToLoad = JsonConvert.DeserializeObject<T>(output);

            return dataToLoad;
        }


    }
}
