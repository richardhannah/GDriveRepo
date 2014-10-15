/*
    File:   Menu1Client.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: clientMain()  

    Description:
 *  
 * Implementation of BaseClient Class.
 * Instantiates a single console robot with a TestBrain loaded
 * Displays instructions on running the robot's test cycles
 * 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PPCourswork
{
    public class Menu1Client : BaseClient
    {

        //Declare Variables

        private ConsoleRobot testRobot;
        

        //Getters and Setters
        //none yet

        //Constructors
        public Menu1Client()
        {
            //Instantiate a robot with a test Brain
            testRobot = new ConsoleRobot(1, new Point(10, 10), new TestBrain(), this);
            
        }

        //Class specific Methods
        public override ConsoleKeyInfo clientMain()
        {
            //set default cursor position - put in a clear space for debugging output. e.g. messages from brain
            Point dPos = new Point(40, 21);

            //Draw initial Screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("1: Robot that can render itself on the console");
            drawHorizRule(1);
            testRobot.draw();
            drawHorizRule(19);
            testRobot.report();

            /*infobox method does not support newline characters
             * for code readability create fixed length strings (infobox length - 2) and concatenate.
             */
            string infoBoxText1 = "press space to run test pattern  ";
            string infoBoxText2 = "press z for zigzag pattern       ";
            string infoBoxText3 = "press q for square pattern       ";
            string infoBoxText4 = "press h to return home           ";
            string infoBoxText = infoBoxText1 + infoBoxText2 + infoBoxText3 + infoBoxText4;

            infoBox(new Point(40, 5), 35, infoBoxText);//create infobox
            
            Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position

            //Collect keyboard input 
            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();
            testRobot.handleInput(keypress.Key);
            
            return keypress;
            
        }


        

        
    }
}
