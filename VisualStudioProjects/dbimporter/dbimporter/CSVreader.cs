using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dbimporter
{
    class CSVreader : StreamReader
    {

        private List<string[]> data;

        public List<string[]> Data
        {
            get { return data; }
        }

        public CSVreader(string file)
            : base(file)
        {
            data = new List<string[]>();

            string line = ReadLine();

            while (line != null)
            {
                data.Add(line.Split(';'));
                line = ReadLine();
            }
        }

        public string[] ReadLine(int line)
        {
            return data[line];
        }
        
    }
}
