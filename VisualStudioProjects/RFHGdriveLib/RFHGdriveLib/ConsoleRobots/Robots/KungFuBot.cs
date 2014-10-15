/*
    File:   KungFuBot.cs
    Version:    1.0
    Date: 13th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: MyTarget
 *  Public Methods: roundHouseKick(),sweep(),punch(), flyingkick()  

    Description:
    
 * Bruce Lee in Robot Form.... utterly terrifying!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace PPCourswork
{
    class KungFuBot : ColliderBot
    {
        //Declare Variables

        private KungFuBot myTarget;

        //Getters and Setters

        public KungFuBot MyTarget
        {
            get { return myTarget; }
        }

        //Constructors

        public KungFuBot(int rID, Point home, BaseBrain brainType, BaseClient callingClient): base(rID,home,brainType,callingClient)
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

        public void roundHouseKick(KungFuBot target)
        {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Robot {0} roundhouses Robot {1}", this.robotID, target.robotID);
        }

        public void sweep(KungFuBot target)
        {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Robot {0} sweeps Robot {1}", this.robotID, target.robotID);
        }

        public void punch(KungFuBot target)
        {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Robot {0} punches Robot {1}", this.robotID, target.robotID);
        }

        public void flyingKick(KungFuBot target)
        {
        }

        protected override Collision checkCollision(){

            Collision collisionType = base.checkCollision();

            

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

            foreach (KungFuBot robot in client.RobotList)
            {
                if (robot.CurrPos == targetSquare)
                {
                    Console.SetCursorPosition(40, 22);

                    myTarget = robot;
                }
                else
                {

                }
            }

            return collisionType;
            
        }

        



    }
}
