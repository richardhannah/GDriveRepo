/*
    File:   Menu4Client.cs
    Version:    1.0
    Date:   12th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: clientMain()   

    Description:
 *  *  
 * Implementation of BaseClient Class.
 * Instantiates 12 ColliderBots on the screen.
 * all 12 robots are loaded with BrRandomBrains
 * User can start and stop the simulation by pressing the spacebar
 * 
 * This client also instantiates a collision map which the robots will check when they move
 * The infobox and horizRule methods of the base class are also overidden so that the collision map
 * is updated with the positions of the borders
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Threading;

namespace PPCourswork
{
    class Menu4Client : BaseClient
    {
        //Declare Variables
        

        //Getters and Setters

        

        //Constructors

        public Menu4Client()
        {
            
            //Instantiate robots with BrRandom Brains
            ColliderBot tempRobot;
            for (int i = 0; i < 12; i++)
            {
                tempRobot = new ColliderBot(i, new Point(10 + i, 10), new BrRandom(), this);
                robotList.Add(tempRobot);
            }

            //Instantiate a collision map that fits the console window
            CollisionMap = new bool[Console.WindowWidth, Console.WindowHeight];
        }


        //Class Specific Methods

        public override ConsoleKeyInfo clientMain()
        {
            //set default cursor position - put in a clear space for debugging output. e.g. messages from brain
            Point dPos = new Point(40, 12);

            

            //Draw initial Screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("4: Random Movement and Collison Detection");
            drawHorizRule(1);
            
            drawHorizRule(19);
            

            /*infobox method does not support newline characters
             * for code readability create fixed length strings (infobox length - 2) and concatenate.
             */
            string infoBoxText1 = "press space to start and stop    ";
            string infoBoxText2 = "the simulation                   ";
            
            string infoBoxText = infoBoxText1 + infoBoxText2 ;

            infoBox(new Point(40, 5), 35, infoBoxText);//create infobox


            foreach (ConsoleRobot robot in robotList)
            {
                robot.draw();
            }

            Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position

            //Check for a consolekey press - stop the simulation if its the spacebar
            do
            {
                while (!Console.KeyAvailable)
                {
                    foreach (ConsoleRobot robot in robotList)
                    {
                        robot.handleInput(ConsoleKey.Spacebar);
                    }
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);


            //Collect keyboard input

            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();
              
            return keypress;
        }


        protected override void drawHorizRule(int rowPos)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                CollisionMap[i, rowPos] = true; 
            }
            base.drawHorizRule(rowPos);
        }

        protected override void infoBox(Point boxPos, int width, string text)
        {
            //calculate number of rows required
            int height = 3 + text.Length / width;

            for (int x = boxPos.X; x < boxPos.X + width; x++)
            {
                for (int y = boxPos.Y; y < boxPos.Y + height; y++)
                {
                    CollisionMap[x, y] = true;
                }

            }

            base.infoBox(boxPos, width, text);
        }


    }
}
