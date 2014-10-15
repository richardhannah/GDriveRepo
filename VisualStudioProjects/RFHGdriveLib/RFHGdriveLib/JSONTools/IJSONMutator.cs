using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFHGdriveLib.JSONTools
{
    interface IJSONMutator
    {
        void LoadData(string filename);
        void SaveData();

    }
}
