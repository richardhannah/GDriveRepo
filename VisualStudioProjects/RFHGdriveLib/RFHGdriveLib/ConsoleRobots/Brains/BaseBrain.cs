/*
    File:   BaseBrain.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
 *  Public Properties: assignedRobot
 *  Public Methods: processKeyPress(), collisionHandler()

    Description:
 *  Abstract Base Class which defines a robot's brain.
 *  
 * Defines 2 constructors - the first is empty - this is for robot initialization. Once the robot is initialized it's constructor
 * will instantiate a new brain based on the parameter sent to the robot's constructor.
 * 
 * Contains method signatures for processing key presses sent to the brain and a collision handler
 * 
 * *note to self: not happy with property for consoleRobot in this base class - should be BaseRobot perhaps? Works ok for
 * now but need to revisit this.
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    public abstract class BaseBrain
    {
        //Declare Variables
        protected ConsoleRobot robot;// refers to the robot this brain belongs to


        //Getters and Setters
        public ConsoleRobot assignedRobot
        {
            
            set { robot = value; }
        }

        //Constructors
        public BaseBrain()
        {

        }

        public BaseBrain(ConsoleRobot owningRobot)
        {
            robot = owningRobot;
        }


        //Class Specific Methods
        public virtual void processKeyPress(ConsoleKey keypress)
        {

            Console.WriteLine("Basebrain processing");
        }

        public virtual void collisionHandler(Collision CollisionType)
        {
        }

    }
}
