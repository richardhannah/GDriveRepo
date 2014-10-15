using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFHGdriveLib.JSONTools
{
    public class CharMutator : IJSONMutator
    {
        private CharData character;

        public void LoadData(string filename) {

            //character = StaticJSONSerializer<CharData>.loadJSONData(filename);
        
        }
        
        public void SaveData() {

            StaticJSONSerializer.saveJSONData(character);
        
        }


        public void AddSkill(string skillName)
        {
            //character.Skills.Add(skillName);
        }

        public void ChangeName(string newName)
        {
            //character.CharName = newName;
        }

        public void testMethod()
        {
        }
    }
}
