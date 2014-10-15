using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RFHGdriveLib;

namespace CharacterGen
{
    public class Character
    {
        //variables

        private string charName;
        private int tier;
        private int level;
        private string t1Skill;
        private int t1SkillBonus;
        


        //properties
        public string CharName
        {
            get { return charName; }
            
        }
        public int Tier
        {
            get { return tier; }
            
        }
        public int Level
        {
            get { return level; }
            
        }
        public string T1Skill
        {
            get { return t1Skill; }
            
        }
        public int T1SkillBonus
        {
            get { return t1SkillBonus; }
            
        }

        //Constructors

        public Character()
        {
            //Generate name
            NameGenerator nameGen = new NameGenerator();
            charName = nameGen.getName();
            

            //set tier
            tier = 1;

            //set Level
            level = 1;

            //set skill type
            Random RNG = new Random();
            int rollSkillType = RNG.Next(1,5);

            switch (rollSkillType)
            {
                case 1:
                    t1Skill = "Population";
                    break;
                case 2:
                    t1Skill = "Science";
                    break;
                case 3:
                    t1Skill = "Economy";
                    break;
                case 4:
                    t1Skill = "Production";
                    break;
                case 5:
                    t1Skill = "Espionage";
                    break;
            }

            t1SkillBonus = RNG.Next(1,11);
                




        }

        public void levelUp(){

            Random RNG = new Random();


            if (level < 5)
            {
                level++;
                t1SkillBonus += RNG.Next(1, 11);
            }
            else { }



        }



    }
}
