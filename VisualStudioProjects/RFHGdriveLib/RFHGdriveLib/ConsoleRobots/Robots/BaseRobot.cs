/*
    File:   BaseRobot.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: RobotID, Facing, HomePos, CurrPos
 *  Public Methods: report(), switchBrain()

    Description:
 * 
 * Abstract Base Class which defines a robot.
 * 
 * Defines the Compass enumeration for orientation values.
 * Note the ordering of these values is important to allow meaningful cycling.
 * Defines Collision enumeration for determining which type of collisions the robot may encounter
 * 
 * Contains methods which define simple movements - forward, back, turn left and right
 * 
 * Simple reporting method which shows the robots position and orientation
 * 
 * method signature for switchBrain which will allow for a robots brain to be swapped out and
 * replaced at runtime depending on requirements (eg. switching from random movement to user control)
 * 
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PPCourswork
{

    public enum Compass {north, east, south, west};
    public enum Collision { none, boundary, scenery, robot }


    public abstract class BaseRobot
    {

        //Declare Variables
        protected int robotID;
        protected Compass facing;
        protected Point homePos;
        protected Point currPos;
        protected Point lastPos;


        //Getters and Setters
        public int RobotID
        {
            get { return robotID; }
        }

        public Compass Facing
        {
            get { return facing; }
        }

        public Point HomePos
        {
            get { return homePos; }
        }

        public Point CurrPos
        {
            get { return currPos; }
            set { currPos = value; }
        }


        //Constructors
        public BaseRobot(int rID, Point home)
        {
            robotID = rID;
            facing = Compass.north;
            homePos = home;
            currPos = home;

        }


        //Class Specific Methods


        //Movement methods
        protected virtual void move()
        {
            //Calculate which square the robot is about to move into

            Point targetSquare = new Point(0, 0);

            switch (Facing)
            {
                case Compass.north:
                    targetSquare = new Point(currPos.X, currPos.Y - 1);
                    break;
                case Compass.east:
                    targetSquare = new Point(currPos.X + 1, currPos.Y);
                    break;
                case Compass.south:
                    targetSquare = new Point(currPos.X, currPos.Y + 1);
                    break;
                case Compass.west:
                    targetSquare = new Point(currPos.X - 1, currPos.Y);
                    break;
            }

            if (targetSquare.X < 0 || targetSquare.Y < 0)
            {


                //Console.WriteLine("out of bounds");
            }
            else if (targetSquare.X > Console.WindowWidth - 1 || targetSquare.Y > Console.WindowHeight - 1)
            {


                //Console.WriteLine("out of bounds");
            }
            else
            {
                currPos = targetSquare;
            }

        }

        protected virtual void moveBack()
        {
            //Calculate which square the robot is about to move into

            Point targetSquare = new Point(0, 0);

            switch (Facing)
            {
                case Compass.north:
                    targetSquare = new Point(currPos.X, currPos.Y + 1);
                    break;
                case Compass.east:
                    targetSquare = new Point(currPos.X - 1, currPos.Y);
                    break;
                case Compass.south:
                    targetSquare = new Point(currPos.X, currPos.Y - 1);
                    break;
                case Compass.west:
                    targetSquare = new Point(currPos.X + 1, currPos.Y);
                    break;
            }

            if (targetSquare.X < 0 || targetSquare.Y < 0)
            {


                Console.WriteLine("out of bounds");
            }
            else if (targetSquare.X > Console.WindowWidth - 1 || targetSquare.Y > Console.WindowHeight - 1)
            {


                Console.WriteLine("out of bounds");
            }
            else
            {
                currPos = targetSquare;
            }

        }

        protected virtual void turnRight()
        {
            if ((int)facing < 3)
            {
                facing++;
            }
            else
            {
                facing = Compass.north;
            }
        }

        protected virtual void turnLeft()
        {
            if ((int)facing > 0)
            {
                facing--;
            }
            else
            {
                
                facing = Compass.west;
            }
        }



        public virtual void report()
        {
            Console.WriteLine("Robot ID: {0}         ", RobotID);
            Console.WriteLine("Facing: {0}           ", facing);
            Console.WriteLine("Home Position: {0}    ", homePos);
            Console.WriteLine("Current Position: {0} ", currPos);

        }

        public virtual void switchBrain(BaseBrain brainType)
        {
            
        }
        

    }
}
