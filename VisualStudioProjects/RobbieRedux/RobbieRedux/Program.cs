using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graphicgrid;
using Robby;
using System.Windows.Forms;

namespace RobbieRedux
{
    class Program
    {
        static void Main(string[] args)
        {

            //set up robot and room
            Robot robby = new Robot();
            Room room = new Room(1);
            Picture pic = new Picture(room, robby);

            //declare vars for console

            int userinput = 0;


            //place Robby
            robby.setX(1);
            robby.setY(1);


            //draw the room
            pic.draw();


            //loop until user chooses to exit
            do {

                //write out the menu
                Console.WriteLine("Choose an action for Robby");

                Console.WriteLine("1. Move forward");
                Console.WriteLine("2. Turn Left");
                Console.WriteLine("3. Turn Right");
                Console.WriteLine("4. Random Move");
                Console.WriteLine("5. Exit");

                //determine action from userinput
                if (userinput == 1)
                {
                    //move forward
                    robby.move();
                    pic.draw();
                }
                else if (userinput == 2)
                {
                    //turn left
                    robby.left();
                    pic.draw();
                }
                else if (userinput == 3)
                {
                    //turn right
                    robby.right();
                    pic.draw();
                }
                else if (userinput == 4)
                {
                    Random rng = new Random();

                    //generate random numbers and use setX and setY methods to move robby to new coordinates
                    robby.setX((rng.Next(17)) + 1);
                    robby.setY((rng.Next(17)) + 1);
                    pic.draw();
                }
                else
                { }

                //collect userinput
                userinput = Convert.ToInt32(Console.ReadLine());

            } while (userinput != 5);//exit if userinput is 5


           

        }
    }
}
