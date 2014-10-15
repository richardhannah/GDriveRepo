/*
    File:   BrUserControl.cs
    Version:    1.0
    Date:   11th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: processKeyPress()   

    Description:
 * 
 * Implementation of BaseBrain abstract class that allows for User control.
 * 
 * Thread Delay set to 0 so that the robot moves instantly when the user presses a key
 * 
 * *Note: No custom collision detection implemented here 
 * 
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    public class BrUserControl : BaseBrain
    {
        //Declare Variables

        

        //Getters and Setters

        //Constructors

        //use this constructor for initializing a robot
        public BrUserControl()
        {
            
        }

        //use this constructor when creating a new brain for an existing robot.
        public BrUserControl(ConsoleRobot owningRobot): base(owningRobot)
        {
            robot.ThreadDelay = 0;
            robot.RobotColor = ConsoleColor.Green;
        }

        //Class Specific Methods

        public override void processKeyPress(ConsoleKey keypress)
        {

            

            switch (keypress)
            {
                case ConsoleKey.UpArrow://forward
                    Console.Write("Moving forward");
                    robot.move();
                    break;
                case ConsoleKey.DownArrow://backward
                    Console.Write("Moving backward");
                    robot.moveBack();
                    break;
                case ConsoleKey.LeftArrow://turn left
                    Console.Write("turning left");
                    robot.turnLeft();
                    break;
                case ConsoleKey.RightArrow://turn right
                    Console.Write("turning right");
                    robot.turnRight();

                    break;
            }








        }

    }
}
