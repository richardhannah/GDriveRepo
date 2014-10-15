/*
    File:   BaseClient.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: RobotList, DefaultColour, CollisionMap
 *  Public Methods: runClient(),ClientMain()

    Description:
 *  Base class for client applications to interact with the robots
 *  
 *  Instantiated clients are started with the runClient method
 *  
 *  Implementation of derived classes occurs mainly within the ClientMain method - can be treated much like
 *  the default main function
 *  
 *  The KeyInput method defines the main loop and runs the client unless the esc key is pressed.
 *  
 *  Also Contains 2 helper methods to lay out "GUI components" InfoBox and HorizRule
 *  *NB - the InfoBox doesn't support newline characters at present
 *  
 *  Defines CollisionMap property - a 2D boolean array used for collision checking
 *  
 *  Note to self: Quite a lot of implementation in this class - perhaps should not be abstract? 
 *  
 * TODO - a debug logging method to standardize the output from other program objects during testing
 * either to send messages to a default screen location - or to write to a file (or both?)
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
    public abstract class BaseClient
    {

        //Declare Variables
        private MainMenu menu;
        private ConsoleColor defaultColor;
        private bool[,] collisionMap;
        protected List<BaseRobot> robotList;
        

        //Getters and Setters

        public List<BaseRobot> RobotList
        {
            get { return robotList; }
        }


        public ConsoleColor DefaultColor
        {
            get { return defaultColor; }
        }

        

        public bool[,] CollisionMap
        {

            get { return collisionMap; }
            set { collisionMap = value; }

        }
        //Constructors

        public BaseClient()
        {
            menu = new MainMenu();
            defaultColor = ConsoleColor.White;
            robotList = new List<BaseRobot>();
        }


        //Class Specific Methods


        //Call this to run the client
        public void runClient(){

            keyInput();
            }

        //loop the ClientMain method unless the escape key is pressed
        protected void keyInput()
        {
            ConsoleKeyInfo keypress;

            do
            {
                keypress = clientMain();
                

            }
            while (keypress.Key != ConsoleKey.Escape);

            Console.Clear();
            menu.showMenu();
        }

        //default main function
        public virtual ConsoleKeyInfo clientMain(){
            ConsoleKeyInfo keypress;
            
            Console.WriteLine("Client Running");

            keypress = Console.ReadKey();
            return keypress;
        }

        //Draw a horizontal line across the screen
        protected virtual void drawHorizRule(int rowPos)
        {
            Console.SetCursorPosition(0, rowPos);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, rowPos);
                Console.Write("-");
            }
        }


        //draw a box containing text at the specified point
        protected virtual void infoBox(Point boxPos, int width, string text)
        {
            
            Point cursor = new Point(boxPos.X, boxPos.Y);

            Console.SetCursorPosition(cursor.X, cursor.Y);
            //calculate number of rows required
            int height = 1 + text.Length / width;

            //Draw top border
            for (int topBorder = 0; topBorder < width; topBorder++)
            {
                Console.Write("-");
            }

            //Draw bottom border

            cursor.Y = boxPos.Y + height + 1;
            Console.SetCursorPosition(cursor.X, cursor.Y);
            for (int botBorder = 0; botBorder < width; botBorder++)
            {
                Console.Write("-");
            }

            //Draw sides

            cursor.Y = boxPos.Y + 1;
            Console.SetCursorPosition(cursor.X, cursor.Y);

            for (int row = 0; row < height; row++)
            {
                Console.Write("|");
                for (int col = 0; col < (width - 2); col++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                cursor.X = boxPos.X;
                cursor.Y++;
                Console.SetCursorPosition(cursor.X, cursor.Y);
            }
            

            //insert text
            int textIndex = 0;

            cursor.X = boxPos.X + 1;
            cursor.Y = boxPos.Y + 1;
            Console.SetCursorPosition(cursor.X, cursor.Y);

            for (int textY = 0; textY < height; textY++)
            {
                
                Console.SetCursorPosition(cursor.X, cursor.Y);

                for (int textX = 0; textX < width -2; textX++)
                {
                    if (textIndex < text.Length)
                    {
                        Console.Write(text[textIndex]);
                        textIndex++;
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                cursor.Y++;
            }
                
                
                
                
            

        }


    }
}
