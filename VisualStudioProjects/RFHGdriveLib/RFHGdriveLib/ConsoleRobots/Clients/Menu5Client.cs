/*
    File: Menu5Client
    Version:    1.0
    Date:  12th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: clientMain()   

    Description: Because there's no point in creating 12 robots and not have them fight each other.
 *  
 * Creates 12 KungFuBots - 1 under user control using kungFuBrain. The remainder are under AI control
 * using AIKungFuBrain
 * 
 * TODO
 * 
 * Robots currently face north by default - would like to have them facing different directions
 * May require an additional parameter in KungFuBot constructor
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using WMPLib;

namespace PPCourswork
{
    class Menu5Client : BaseClient
    {
        //Declare Variables
        private List<Point> startPoints;
        bool playMusic = true;
        SFX music;
        


        //Getters and Setters



        //Constructors

        public Menu5Client()
        {
            music = new SFX();

            //Space the robots out

            startPoints = new List<Point>();
            startPoints.Add(new Point(10, 7));
            startPoints.Add(new Point(13, 7));
            startPoints.Add(new Point(16, 7));
            startPoints.Add(new Point(10, 10));
            startPoints.Add(new Point(13, 10));
            startPoints.Add(new Point(16, 10));
            startPoints.Add(new Point(10, 13));
            startPoints.Add(new Point(13, 13));
            startPoints.Add(new Point(16, 13));
            startPoints.Add(new Point(10, 16));
            startPoints.Add(new Point(13, 16));
            startPoints.Add(new Point(16, 16));
            

            
            //Instantiate a robot with a brain that allows direct user control
            KungFuBot tempRobot;

            tempRobot = new KungFuBot(0, startPoints[0], new KungFuBrain(), this);
            robotList.Add(tempRobot);

            //Instantiate AI controlled Robots
            for (int i = 1; i < 12; i++)
            {
                tempRobot = new KungFuBot(i, startPoints[i], new AIKungFuBrain(), this);
                robotList.Add(tempRobot);
            }
            CollisionMap = new bool[Console.WindowWidth, Console.WindowHeight];
        }


        public override ConsoleKeyInfo clientMain()
        {
            if (playMusic == true)
            {
                playMusic = false;

                try
                {
                    if (music.MusicFX.playState == WMPPlayState.wmppsPlaying)
                    {

                    }
                    else if (music.MusicFX.playState == WMPPlayState.wmppsMediaEnded) 
                    {
                        music.MusicFX.URL = "dragon.mp3";
                        music.MusicFX.controls.play();
                    }
                    else
                    {
                        music.MusicFX.URL = "dragon.mp3";
                        music.MusicFX.controls.play();
                    }

                }
                catch
                {
                    playMusic = true; //try to turn the music back on if it crashes
                }
                
                
                
            }
            else { }

            //set default cursor position - put in a clear space for debugging output. e.g. messages from brain
            Point dPos = new Point(40, 21);

            

            //Draw initial Screen
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("4: Kung Fu");
            drawHorizRule(1);
            
            drawHorizRule(19);
            

            /*infobox method does not support newline characters
             * for code readability create fixed length strings (infobox length - 2) and concatenate.
             */
            string infoBoxText1 = "Defeat all enemies               ";
            string infoBoxText2 = "                                 ";
            string infoBoxText3 = "                                 ";
            string infoBoxText4 = "                                 ";
            string infoBoxText = infoBoxText1 + infoBoxText2 + infoBoxText3 + infoBoxText4;

            infoBox(new Point(40, 5), 35, infoBoxText);//create infobox


            foreach (KungFuBot robot in robotList)
            {
                robot.draw();
            }

            Console.SetCursorPosition(dPos.X, dPos.Y);//return cursor to default position


            
            

            
            //Collect keyboard input 
            
            
            ConsoleKeyInfo keypress;
            keypress = Console.ReadKey();

            foreach(KungFuBot robot in robotList){

                robot.handleInput(keypress.Key);

            }
              
            return keypress;
        }


        protected override void drawHorizRule(int rowPos)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                CollisionMap[i, rowPos] = true; 
            }
            base.drawHorizRule(rowPos);
        }

        protected override void infoBox(Point boxPos, int width, string text)
        {
            //calculate number of rows required
            int height = 3 + text.Length / width;

            for (int x = boxPos.X; x < boxPos.X + width; x++)
            {
                for (int y = boxPos.Y; y < boxPos.Y + height; y++)
                {
                    CollisionMap[x, y] = true;
                }

            }

            base.infoBox(boxPos, width, text);
        }


    
    }
}
