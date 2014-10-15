/*
    File:   TestBrain2.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: processKeyPress()

    Description:
 * 
 * Basic brain for testing purposes
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    public class TestBrain2 : BaseBrain
    {
        //Declare Variables

        //Getters and Setters

        //Constructors
        public TestBrain2()
        {

        }

        public TestBrain2(ConsoleRobot owningRobot) : base(owningRobot)
        {

        }

        //Class Specific Methods
        public override void processKeyPress(ConsoleKey keypress)
        {

            if (keypress == ConsoleKey.Spacebar)
            {

                Console.WriteLine("testbrain2 processing");

                

                
            }
        }

    }
}
