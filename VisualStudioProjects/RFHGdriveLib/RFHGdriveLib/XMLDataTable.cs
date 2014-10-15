using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RFHGdriveLib
{
    public class XMLDataTable
    {

        public void write(DataTable table, string fileName)
        {
            table.WriteXml(fileName, XmlWriteMode.WriteSchema);

        }

        public DataTable read(string filename)
        {
            DataTable table = new DataTable();

            try
            {
                table.ReadXml(filename);
            }
            catch
            {
                return table;
            }

            return table;
            
        }



    }
}
