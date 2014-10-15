using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFHGdriveLib
{
    class BaseChar
    {
        protected string charName;
        protected int tier;
        protected int level;
        protected Dictionary<string,int> skills;

        public BaseChar()
        {
            //Generate name
            NameGenerator nameGen = new NameGenerator();
            charName = nameGen.getName();
            

            //set tier
            tier = 1;

            //set Level
            level = 1;
        }

        public void levelUp(){
            tier++;
        }

        public void tierUp(){
            level++;
        }
    }
}
