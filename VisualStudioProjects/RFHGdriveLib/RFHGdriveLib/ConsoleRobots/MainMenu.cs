/*
    File:   MainMenu.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties:
 *  Public Methods: showMenu()

    Description:
 *  
 *  This class displays a menu for the user
 *  Depending on their choice the appropriate client will start up
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    public class MainMenu
    {

        //Declare Variables
        //none yet

        //Getters and Setters
        //none yet

        //Constructors
        //none yet

        //Class Specific Methods

        public void showMenu()
        {
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("CE0824: Programming Practice");

            Console.SetCursorPosition(10, 10);
            Console.WriteLine("1: Robot that can render itself on the console");
            Console.SetCursorPosition(10, 11);
            Console.WriteLine("2: interactive user control of a single console robot.");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("3: interactive control of multiple console robots.");
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("4: Random Movement and Collison Detection");
            Console.SetCursorPosition(10, 14);
            Console.WriteLine("5: Kung Fu");
            Console.SetCursorPosition(10, 16);
            Console.WriteLine("Enter menu choice (1-5):");
            Console.SetCursorPosition(34, 16);

            string choice = Console.ReadLine();

            
            switch (choice)
                {
                    case "1":
                        menu1();
                        break;
                    case "2":
                        menu2();
                        break;
                    case "3":
                        menu3();
                        break;
                    case "4":
                        menu4();
                        break;
                    case "5":
                        menu5();
                        break;
                    default:
                        Console.Clear();
                        Console.SetCursorPosition(10, 18);
                        Console.WriteLine("Invalid choice - please retry");
                        showMenu();
                        break;
                }
            
            
                
        }

        private void menu1()
        {
            Console.Clear();
            Menu1Client client = new Menu1Client();
            client.runClient();
        }

        private void menu2()
        {
            Console.Clear();
            Menu2Client client = new Menu2Client();
            client.runClient();
        }

        private void menu3()
        {
            Console.Clear();
            Menu3Client client = new Menu3Client();
            client.runClient();
        }

        private void menu4()
        {
            Console.Clear();
            Menu4Client client = new Menu4Client();
            client.runClient();
        }

        private void menu5()
        {
            Console.Clear();
            Menu5Client client = new Menu5Client();
            client.runClient();
        }
    }
}

