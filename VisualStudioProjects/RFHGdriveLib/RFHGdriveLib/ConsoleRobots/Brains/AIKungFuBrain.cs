/*
    File: AIKungFuBrain.cs  
    Version:    1.0
    Date:  11th May 2013 
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork 
    Properties: n/a
    Methods: collisionHandler()

    Description: This is the AI version of the Kung Fu Robot Brain.
 * Overrides BrRandoms collision handler to produce some more interesting sounds
 * 
 * //TODO
 * 
 * Create Pathfinding Function to target the nearest enemy robot 
 * Create Attack selection function - eg. punch/roundhouse
 * 
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WMPLib;

namespace PPCourswork
{
    class AIKungFuBrain : BrRandom
    {
        //Declare Variables

        private new KungFuBot robot;

        SFX sound;
        

        //Getters and Setters

        //Constructors

        //use this constructor for initializing a robot
        public AIKungFuBrain()
        {
            
        }

        //use this constructor when creating a new brain for an existing robot.
        public AIKungFuBrain(KungFuBot owningRobot)
            : base(owningRobot)
        {
            robot = owningRobot;
            robot.ThreadDelay = 0;
            robot.RobotColor = ConsoleColor.Yellow;

            sound = new SFX();


            


        }

        //Class Specific Methods


        public override void collisionHandler(Collision CollisionType)
        {
            switch (CollisionType)
            {
                case Collision.boundary:
                    robot.turnLeft(2);
                    Console.SetCursorPosition(40, 21);
                    Console.WriteLine("out of bounds");
                    //Console.Beep(500, 100);
                    try
                    {
                        sound.SwooshFX.URL = "swoosh.mp3";
                        sound.SwooshFX.controls.play();
                    }
                    catch
                    { }

                    break;
                case Collision.robot:
                    Random RNG = new Random();
                    int attack = RNG.Next(3);
                    switch (attack)
                    {
                        case 0:
                            robot.roundHouseKick(robot.MyTarget);
                            //Play sfx
                            try
                            {
                                sound.RHouseFX.URL = "roundhouse.wav";
                                sound.RHouseFX.controls.play();
                            }
                            catch
                            { }
                             
                            break;
                        case 1:
                            robot.sweep(robot.MyTarget);
                            //Play sfx
                            try
                            {
                                sound.SweepFX.URL = "sweep.wav";
                                sound.SweepFX.controls.play();
                            }
                            catch
                            { }
                            break;
                        case 2:
                            robot.punch(robot.MyTarget);
                            try
                            {
                                sound.PunchFX.URL = "punch.wav";
                                sound.PunchFX.controls.play();
                            }
                            catch
                            { }
                            break;
                    }

                    //Console.Beep(1000, 100);
                    break;
                    
                case Collision.scenery:
                    robot.turnLeft(2);
                    Console.SetCursorPosition(40, 23);
                    Console.WriteLine("scenery collision");
                    //Console.Beep(2000, 100);
                    try
                    {
                        sound.SwooshFX.URL = "swoosh.mp3";
                        sound.SwooshFX.controls.play();
                    }
                    catch
                    { }
                    break;
            }
        }



    }
}
