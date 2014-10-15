/*
    File:   KungFuBrain.cs
    Version:    1.0
    Date:   11th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: n/a   

    Description:
 * 
 * Inherits from BrUsercontrol brain which allows the user to control movement
 * 
 * TODO
 * 
 * Implement controls for attacks
 * Implement custom collision handling
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    class KungFuBrain : BrUserControl
    {
        //Declare Variables

        //Getters and Setters

        //Constructors

        //use this constructor for initializing a robot
        public KungFuBrain()
        {
            
        }

        //use this constructor when creating a new brain for an existing robot.
        public KungFuBrain(ConsoleRobot owningRobot)
            : base(owningRobot)
        {
            robot.ThreadDelay = 10; //add a small delay to help prevent sound effects crashing
            robot.RobotColor = ConsoleColor.Green;
        }

        //Class Specific Methods



    }
}
