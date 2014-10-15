/*
    File:   ConsoleRobot.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: RobotBrain, ThreadDelay, RobotColor 
 *  Public Methods: move(), moveBack(), turnLeft(), turnRight(), draw(), report(), switchBrain()

    Description:
 *  
 *  Implementation of BaseRobot abstract class
 *  
 *  Constructor gets the type of brain that was instantiated in the calling client and creates
 *  a new brain using the proper constructor which will link the brain to the robot
 *  
 *  The constructor also sets default values for robot colour, thread Delay and populates the
 *  gfxfacing dict with values to indicate which direction the robot is facing 
 *  
 *  Thread delay is the pause time between movements - default 200ms. Robot brains can reset this value
 *  depending on what is required (eg. user control brains will likely have the thread delay set to 0)
 *  
 *  Base movement methods are all overriden and have optional parameters for making multiple moves
 *  and reporting after each step.
 *  
 *  2 draw methods implemented - 1 is private and used for robot movement - the other is public
 *  and used by the client to draw the robots initial position
 * 
 *  switchbrain method is implemented
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
    public class ConsoleRobot : BaseRobot
    {
        // Declare variables
        protected Dictionary<Compass, string> gfxFacing;
        protected BaseBrain robotBrain;
        protected int threadDelay;
        protected ConsoleColor robotColor;
        protected BaseClient client;



        //Getters and Setters
        public BaseBrain RobotBrain
        {
            get { return robotBrain; }
            set { robotBrain = value; }
        }

        public int ThreadDelay
        {
            set { threadDelay = value; }
        }

        public ConsoleColor RobotColor
        {
            set { robotColor = value; }
        }

        //Constructors

        public ConsoleRobot(int rID, Point home, BaseBrain brainType, BaseClient callingClient): base(rID,home)
        {
            client = callingClient;

            //Defaults - brain choice may alter these values later

            //set the default colour of the robot in case the brain does not assign a colour
            robotColor = client.DefaultColor;

            //set the thread delay
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

        //Method for handling input from the client

        public void handleInput(ConsoleKey keypress)
        {
            robotBrain.processKeyPress(keypress);
        }

        

        //Movement methods

        
        public virtual void move(int steps = 1, bool reporting = false)
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

        public virtual void moveBack(int steps = 1, bool reporting = false)
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

        public void turnRight(int steps = 1, bool reporting = false)
        {

            for (int i = 0; i < steps; i++)
            {
                lastPos = currPos;
                base.turnRight();
                Thread.Sleep(threadDelay);
                draw();
                if (reporting == true)
                {
                    report();
                }
                else { }
            }
        }

        public void turnLeft(int steps = 1, bool reporting = false)
        {

            for (int i = 0; i < steps; i++)
            {
                lastPos = currPos;
                base.turnLeft();
                Thread.Sleep(threadDelay);
                draw();
                if (reporting == true)
                {
                    report();
                }
                else { }
            }
        }

        //Drawing methods

        //used with the robot's move methods
        protected void draw(Point lastPos)
        {
            Console.SetCursorPosition(lastPos.X, lastPos.Y);
            Console.Write(" ");
            Console.SetCursorPosition(base.currPos.X, base.currPos.Y);
            Console.ForegroundColor = robotColor;
            Console.Write(gfxFacing[base.Facing]);
            Console.ForegroundColor = client.DefaultColor;
        }

        //used by the client to draw the robot's initial position
        public void draw()
        {
            Console.SetCursorPosition(base.currPos.X, base.currPos.Y);
            Console.ForegroundColor = robotColor;
            Console.Write(gfxFacing[base.Facing]);
            Console.ForegroundColor = client.DefaultColor;
        }

        //override of report method to put the report in a useful position

        public override void report(){
            Console.SetCursorPosition(0, 20);
            base.report();
        }


        //change the brain of the robot
        public override void switchBrain(BaseBrain brainType)
        {
            //Get the brain type and create a new brain
            Type typeOfBrain = brainType.GetType();
            robotBrain = (BaseBrain)Activator.CreateInstance(typeOfBrain, this);

        }
        

    }
}
