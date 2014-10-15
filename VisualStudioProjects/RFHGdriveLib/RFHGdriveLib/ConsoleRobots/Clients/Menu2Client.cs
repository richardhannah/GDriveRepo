/*
    File:   Menu2Client.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: clientMain()

    Description:
 *  
 * Implementation of BaseClient Class.
 * Instantiates a single console robot with a BrUserControl component loaded
 * Displays instructions on controlling the robot
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PPCourswork
{
    public class Menu2Client :BaseClient
    {
        //Declare Variables

        private ConsoleRobot userBot;

        //Getters and setters

        //Constructors

        public Menu2Client()
        {
            //Instantiate a robot with a brain that allows direct user control
            userBot = new ConsoleRobot(1, new Point(10, 10), new BrUserControl(), this);
        }

        //Class Specific Methods
        public override ConsoleKeyInfo clientMain()
        {
            //set default cursor position - put in a clear space for debugging output. e.g. messages from brain
            Point dPos = new Point(40, 21);

            //Draw initial Screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("2: interactive user control of a single console robot.");
            drawHorizRule(1);
            userBot.draw();
            drawHorizRule(19);
            userBot.report();

            /*infobox method does not support newline characters
             * for code readability create fixed length strings (infobox length - 2) and concatenate.
             */
             
            
            string infoBoxText = "Use Cursor keys to control robot ";

            infoBox(new Point(40, 5), 35, infoBoxText);//create infobox

            Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position


            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();
            userBot.handleInput(keypress.Key);
            return keypress;

            
        }
    }
}
