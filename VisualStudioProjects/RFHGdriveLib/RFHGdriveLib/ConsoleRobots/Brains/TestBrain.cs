/*
    File:   TestBrain.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: processKeyPress()

    Description:
 *  Basic Implementation of the BaseBrain class.
 *  
 * Runs through a series of pre-programmed maneuvers to test the robot's movement functions
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    public class TestBrain : BaseBrain
    {
        // Declare Variables

        //Getters and Setters

        //Constructors

        //use this constructor for initializing a robot
        public TestBrain()
        {

        }

        //use this constructor when creating a new brain for an existing robot.
        public TestBrain(ConsoleRobot owningRobot) : base(owningRobot)
        {
            robot.ThreadDelay = 200;
            robot.RobotColor = ConsoleColor.Red;
        }

        //Class Specific Methods
        public override void processKeyPress(ConsoleKey keypress)
        {

            switch (keypress)
            {
                case ConsoleKey.Spacebar://run testpattern with realtime reporting
                    Console.WriteLine("test pattern running");
                    robot.turnRight(1, true);
                    robot.move(1, true);
                    robot.turnLeft(2, true);
                    robot.move(2, true);
                    robot.turnRight(3, true);
                    robot.move(3, true);
                    robot.turnLeft(1, true);
                    break;
                case ConsoleKey.Z://run zigzag pattern
                    Console.WriteLine("zigzag pattern running");
                    robot.move(4);
                    robot.turnRight();
                    robot.move();
                    robot.turnRight();
                    robot.move();
                    robot.turnLeft();
                    robot.move();
                    robot.turnRight();
                    robot.move();
                    robot.turnLeft();
                    robot.move();
                    robot.turnRight();
                    robot.move();
                    robot.turnLeft();
                    robot.move();
                    robot.turnRight();
                    robot.move();
                    robot.turnLeft();
                    robot.move();
                    robot.turnLeft();
                    robot.move(4);
                    
                    break;
                case ConsoleKey.Q://run square pattern
                    Console.WriteLine("square pattern running");
                    robot.move(4);
                    robot.turnLeft();
                    robot.move(4);
                    robot.turnLeft();
                    robot.move(4);
                    robot.turnLeft();
                    robot.move(4);
                    
                    break;
                case ConsoleKey.H://return home
                    Console.WriteLine("returning home");
                    Console.SetCursorPosition(robot.CurrPos.X, robot.CurrPos.Y);
                    Console.Write(" ");
                    robot.CurrPos = robot.HomePos;
                    
                    break;
            }
            
            

                


                
            
        }

    }
}
