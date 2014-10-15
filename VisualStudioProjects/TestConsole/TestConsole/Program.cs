using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using RFHGdriveLib.JSONTools;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.IO;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialise and assign variables
            Random rng = new Random();
            int randnum = 0;
            int contin =1;

            int numRolls =0;
            int runningTotal =0;
            int attempts = 0;


            //while the user input is not a zero - run code below
            Console.WriteLine("entering main loop");
            while (contin != 0)
            {
                //generate random numbers until a six is generated
                Console.WriteLine("generating random numbers");
                while (randnum < 6)
                {
                    
                    randnum = rng.Next(7);
                    Console.WriteLine(randnum + " is less than 6 - continuing");
                    numRolls++;
                }
                Console.WriteLine("6 has been rolled");
                //add 1 to number of attempts
                attempts++;
                Console.WriteLine("add 1 to number of attempts");

                //add to the running total
                runningTotal += numRolls;
                Console.WriteLine(" add the number of rolls to the running total");
                
                //write out the number of rolls to get a six
                Console.WriteLine("numrolls taken to roll 6:" + numRolls);

                //reset variables
                Console.WriteLine("reset the number of rolls and random number so they are ready for the next loop");

                numRolls = 0;

                randnum = 0;

                //get user input and exit loop if is zero
                Console.WriteLine("press 0 to exit and any other number to continue");
                contin = Convert.ToInt32(Console.ReadLine());




            }

            //display running total and average number of rolls to get a six
            Console.WriteLine("total number of rolls:" + runningTotal);
            Console.WriteLine("average rolls to get 6:" + (runningTotal / attempts));

            Console.ReadLine();

            /*
            StaticJSONSerializer.DataDir = "data";

            CharMutator myChar = new CharMutator();

            myChar.LoadData("testpath.txt");

            myChar.ChangeName("Bob");

            myChar.SaveData();

            int x = 0;
            while (x < 10)
            {
            }


            /*
            CharData character = StaticJSONSerializer.loadCharData("testpath.txt");

            Console.WriteLine(character.CharName);

            foreach (string skill in character.Skills)
            {
                Console.WriteLine(skill);
            }
            
            
            Console.ReadLine();

            /*
            CharData character = new CharData();

            character.CharName = "testName";
            DataAccess.saveCharData(character,"testpath.txt");
            */
            
        }
    }
}
