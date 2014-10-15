/*
    File:   Menu3Client.cs
    Version:    1.0
    Date:   
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: clientMain()   

    Description:
 *  *  
 * Implementation of BaseClient Class.
 * Instantiates 12 Robots on the screen.
 * Only 1 robot is initially loaded with a brain that allows user control
 * The remainder are loaded with TestBrains
 * 
 * User can toggle control of the robots by pressing the f1-f12 keys
 * 
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PPCourswork
{
    class Menu3Client : BaseClient
    {
        //Declare Variables

        private bool[] selectedRobots;//array for determining which robots are under user control

        //Getters and Setters

        //Constructors
        public Menu3Client()
        {
            
            //initialize selected robots array
            selectedRobots = new bool[12]{true,false,false,false,false,false,false,false,false,false,false,false};

            //instantiate first robot with BrUserControl Brain
            ConsoleRobot tempRobot = new ConsoleRobot(0, new Point(10, 10), new BrUserControl(), this);
            robotList.Add(tempRobot);

            //instantiate the rest with TestBrains
            for (int i = 1; i < 12; i++)
            {
                tempRobot = new ConsoleRobot(i, new Point(10 + i, 10), new TestBrain(), this);
                robotList.Add(tempRobot);
            }
        }
        //Class Specific Methods
        public override ConsoleKeyInfo clientMain()
        {
            //set default cursor position - put in a clear space for debugging output. e.g. messages from brain
            Point dPos = new Point(40, 21);

            //Draw initial Screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("3: interactive control of multiple console robots.");
            drawHorizRule(1);
            drawHorizRule(19);
            

            /*infobox method does not support newline characters
             * for code readability create fixed length strings (infobox length - 2) and concatenate.
             */
            string infoBoxText1 = "Use function keys to select robot";
            string infoBoxText2 = "                                 ";
            string infoBoxText3 = "Use Cursor keys to control selected robots";

            string infoBoxText = infoBoxText1 + infoBoxText2 + infoBoxText3;
            infoBox(new Point(40, 5), 35, infoBoxText);//create infobox

            foreach (ConsoleRobot robot in robotList)
            {
                robot.draw();
            }




            Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position


            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();

            robotSelector(keypress.Key);

            
            
            
            foreach (ConsoleRobot robot in robotList)
            {
                robot.handleInput(keypress.Key);
                Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position
            }

            
            
            return keypress;
        }

        //select which robots are under user control
        private void robotSelector(ConsoleKey keypress)
        {

            
            switch(keypress){
                case ConsoleKey.F1:
                    toggleRobot(0);
                    break;
                case ConsoleKey.F2:
                    toggleRobot(1);
                    break;
                case ConsoleKey.F3:
                    toggleRobot(2);
                    break;
                case ConsoleKey.F4:
                    toggleRobot(3);
                    break;
                case ConsoleKey.F5:
                    toggleRobot(4);
                    break;
                case ConsoleKey.F6:
                    toggleRobot(5);
                    break;
                case ConsoleKey.F7:
                    toggleRobot(6);
                    break;
                case ConsoleKey.F8:
                    toggleRobot(7);
                    break;
                case ConsoleKey.F9:
                    toggleRobot(8);
                    break;
                case ConsoleKey.F10:
                    toggleRobot(9);
                    break;
                case ConsoleKey.F11:
                    toggleRobot(10);
                    break;
                case ConsoleKey.F12:
                    toggleRobot(11);
                    break;
                
            }

            
            //check the selectedRobots array and load the appropriate brains into each robot
            for (int i = 0; i < 12; i++)
            {
                
                if (selectedRobots[i] == true)
                {
                    robotList[i].switchBrain(new BrUserControl());
                }
                else
                {
                    robotList[i].switchBrain(new TestBrain());
                }

            }
            

            //return keypress;
        }

        //toggle helper method
        private void toggleRobot(int tRobot)
        {
            if (selectedRobots[tRobot] == true)
            {
                selectedRobots[tRobot] = false;
            }
            else
            {
                selectedRobots[tRobot] = true;
            }
        }


    }
}
