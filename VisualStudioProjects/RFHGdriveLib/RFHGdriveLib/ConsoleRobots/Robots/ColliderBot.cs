/*
    File:   
    Version:    1.0
    Date:   
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: move(), moveBack()   

    Description:
 * 
 *  Inherits from ConsoleRobot Class
 *  
 *  Overrides move() and moveBack() methods to include Collision checking before making a move
 *  
 *  The checkCollision method checks for 3 different types of collision (boundary,robot and scenery)
 *  and sends the result to the robot's brain to determine what to do about it. If the brain has no
 *  Collision handler the robot will simply not move.
 *  
 *  
 * 
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace PPCourswork
{

    

    class ColliderBot : ConsoleRobot
    {
        //Declare Variables

        //Getters and Setters

        //Constructors

        public ColliderBot(int rID, Point home, BaseBrain brainType, BaseClient callingClient): base(rID,home,brainType,callingClient)
        {
            client = callingClient;

            //Defaults - brain choice may alter these values later

            //set the default colour of the robot in case the brain does not assign a colour
            robotColor = client.DefaultColor;
            threadDelay = 200;


            //Get the brain type and create a new brain
            Type typeOfBrain = brainType.GetType();
            robotBrain = (BaseBrain)Activator.CreateInstance(typeOfBrain,this);            

            
            //Initialize the robot's graphics
            gfxFacing = new Dictionary<Compass, string>();

            gfxFacing.Add(Compass.north, "^");
            gfxFacing.Add(Compass.east, ">");
            gfxFacing.Add(Compass.south, "v");
            gfxFacing.Add(Compass.west, "<");
        }

        //Class Specific Methods

        //Movement methods

        //overload of base movement method
        public override void move(int steps = 1, bool reporting = false)
        {
            Collision collision = checkCollision();

            if (collision == Collision.none)
            {
                for (int i = 0; i < steps; i++)
                {
                    lastPos = currPos;
                    base.move();
                    Thread.Sleep(threadDelay);
                    draw(lastPos);

                    if (reporting == true)
                    {
                        report();
                    }
                    else { }
                }
            }
            else
            {

                RobotBrain.collisionHandler(collision);
            
            }
            
        }

        public override void moveBack(int steps = 1, bool reporting = false)
        {
            Collision collision = checkCollision();

            if (collision == Collision.none)
            {
                for (int i = 0; i < steps; i++)
                {
                    lastPos = currPos;
                    base.moveBack();
                    Thread.Sleep(threadDelay);
                    draw(lastPos);

                    if (reporting == true)
                    {
                        report();
                    }
                    else { }
                }
            }
            else
            {
                RobotBrain.collisionHandler(collision);
            }
        
        }

        protected virtual Collision checkCollision()
        {
            //Calculate which square the robot is about to move into

            Point targetSquare = new Point(0,0);

            switch(Facing)
            {
                case Compass.north:
                    targetSquare = new Point(currPos.X, currPos.Y-1);
                    break;
                case Compass.east:
                    targetSquare = new Point(currPos.X +1, currPos.Y);
                    break;
                case Compass.south:
                    targetSquare = new Point(currPos.X, currPos.Y +1);
                    break;
                case Compass.west:
                    targetSquare = new Point(currPos.X -1, currPos.Y);
                    break;
            }

            Console.SetCursorPosition(40, 20);
            Console.WriteLine("                                ");//clear the line
            Console.SetCursorPosition(40, 20);
            Console.WriteLine("Robot {0} target {1}: ",robotID, targetSquare);
            
            //check for edge of console window

            if (targetSquare.X < 0 || targetSquare.Y < 0)
            {
                
                
                return Collision.boundary;
            }
            else if (targetSquare.X > Console.WindowWidth - 1 || targetSquare.Y > Console.WindowHeight - 1)
            {


                return Collision.boundary;
            }
            else
            { }


            //check for other Robots

            

            foreach (ColliderBot robot in client.RobotList)
            {
                if (robot.CurrPos == targetSquare)
                {
                    Console.SetCursorPosition(40, 22);
                    
                    return Collision.robot;
                }
                else
                {
                    
                }
            }


            //check collision map

            if (client.CollisionMap[targetSquare.X, targetSquare.Y] == true)
            {
               
                return Collision.scenery;
            }
            else
            {
                
            }

            return Collision.none;


        }



    }
}
