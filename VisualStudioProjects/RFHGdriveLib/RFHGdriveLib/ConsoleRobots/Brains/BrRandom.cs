/*
    File:   BrRandom.cs
    Version:    1.0
    Date:   11th may 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: processKeyPress(), collisionHandler()   

    Description:
 * 
 * Derives from BaseBrain class. 
 * Added private method for Random movement
 * CollisionHandler method is implemented and makes a different beep depending on what kind of collision
 * the robot has detected. It also turns the robot round if it hits the boundary or part of the scenery.
 * This helps to keep the robots moving in open space rather than at the edges of the environment.
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    class BrRandom : BaseBrain
    {
        //Declare Variables
        

        //Getters and Setters

        //Constructors

        //use this constructor for initializing a robot
        public BrRandom()
        {

        }

        //use this constructor when creating a new brain for an existing robot.
        public BrRandom(ConsoleRobot owningRobot) : base(owningRobot)
        {
            robot.ThreadDelay = 50;
            robot.RobotColor = ConsoleColor.Cyan;
        }

        //Class Specific Methods

        public override void processKeyPress(ConsoleKey keypress)
        {

            randomMovement();
                        
        }

        private void randomMovement()
        {
            Random RNG = new Random();

            //make the random number go up to 5 so the robot will move more often than it turns
            int turnOrMove = RNG.Next(5);

            if (turnOrMove == 0)
            {
                int leftOrRight = RNG.Next(2);
                if (leftOrRight == 0)
                {
                    robot.turnLeft();
                }
                else
                {
                    robot.turnRight();
                }
            }
            else
            {
                robot.move();
            }

        }

        public override void collisionHandler(Collision CollisionType)
        {
            //Make a different noise depending on which type of collision was detected

            switch (CollisionType)
            {
                case Collision.boundary:
                    robot.turnLeft(2);
                    Console.SetCursorPosition(40, 21);
                    Console.WriteLine("                           ");//clear line
                    Console.SetCursorPosition(40, 21);
                    Console.WriteLine("Robot {0}: out of bounds", robot.RobotID);
                    Console.Beep(500, 100);
                    break;
                case Collision.robot:
                    Console.SetCursorPosition(40, 22);
                    Console.WriteLine("                           ");//clear line
                    Console.SetCursorPosition(40, 22);
                    Console.WriteLine("Robot {0}: robot collision", robot.RobotID);
                    Console.Beep(1000,100);
                    break;
                case Collision.scenery:
                    robot.turnLeft(2);
                    Console.SetCursorPosition(40, 23);
                    Console.WriteLine("                           ");//clear line
                    Console.SetCursorPosition(40, 23);
                    Console.WriteLine("Robot {0}: scenery collision", robot.RobotID);
                    Console.Beep(2000, 100);
                    break;
            }
        }


    }
}
