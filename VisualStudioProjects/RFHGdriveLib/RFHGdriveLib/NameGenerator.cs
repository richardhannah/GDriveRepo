using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RFHGdriveLib
{
    public class NameGenerator
    {
        private List<string> fNames;
        private List<string> mNames;
        private List<string> surnames;

        public NameGenerator()
        {

            fNames = new List<string>();
            mNames = new List<string>();
            surnames = new List<string>();

            
            int counter = 0;
            string line;

            

            //load data from text files

            

            StreamReader readFile = new StreamReader("femNames.txt");

            //populate female names
            while ((line = readFile.ReadLine()) != null)
            {
                fNames.Add(line);
                counter++;
            }

            //reset counter

            counter = 0;

            readFile.Close();

            //populate male names

            readFile = new StreamReader("maleNames.txt");

            while ((line = readFile.ReadLine()) != null)
            {
                mNames.Add(line);
                counter++;
            }
            //reset counter

            counter = 0;
            readFile.Close();

            //populate surnames

            readFile = new StreamReader("surnames.txt");
            while ((line = readFile.ReadLine()) != null)
            {
                surnames.Add(line);
                counter++;
            }
            //reset counter

            counter = 0;
            readFile.Close();

            
        }

        public string getFname()
        {
            string fullName;
            Random RNG = new Random();

            int listlen = fNames.Count;
            int selName = RNG.Next(listlen);
            

            int surnLen = surnames.Count;
            int selSurn = RNG.Next(surnLen);
 

            fullName = fNames[selName] + " " + surnames[selSurn];

            return fullName;
        }

        public string getMname()
        {
            string fullName;
            Random RNG = new Random();

            int listlen = mNames.Count;
            int selName = RNG.Next(listlen);


            int surnLen = surnames.Count;
            int selSurn = RNG.Next(surnLen);


            fullName = mNames[selName] + " " + surnames[selSurn];

            return fullName;
        }

        public string getName()
        {
            Random RNG = new Random();
            int mf = RNG.Next(2);
            string fullName;

            if (mf == 0)
            {
                fullName = getFname();
            }
            else
            {
                fullName = getMname();
            }

            return fullName;
        }
        
    }
}
