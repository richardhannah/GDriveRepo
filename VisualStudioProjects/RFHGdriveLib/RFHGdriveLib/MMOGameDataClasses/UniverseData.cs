using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RFHGdriveLib.JSONTools;

namespace RFHGdriveLib.MMOGameDataClasses
{
    public class UniverseData : IJSONData
    {

        //declare vars
        private string idstring;
        private DateTime universeAge;


        //properties
        public string IDString
        {

            get { return idstring; }
            set { idstring = value; }
        }

        public DateTime UniverseAge
        {
            get { return universeAge; }
            set { universeAge = value; }
        }

        //constructors

        public UniverseData()
        {

        }

        


    }
}
