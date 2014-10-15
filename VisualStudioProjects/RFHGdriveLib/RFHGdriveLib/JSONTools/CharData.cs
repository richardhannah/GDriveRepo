using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RFHGdriveLib.JSONTools
{
    public class CharData : IJSONData
    {
        private string charName;

        private List<string> skills;

        public string IDString
        {
            get { return charName; }
            
        }

        public string CharName
        {
            get{return charName;}
            set { charName = value; }
        }

        public List<string> Skills
        {
            get { return skills; }

        }

        public CharData()
        {

            skills = new List<string>();

           

        }
    }
}
