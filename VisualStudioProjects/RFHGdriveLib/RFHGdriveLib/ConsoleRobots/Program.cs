/*
    File:   Program.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: assignedRobot
 *  Public Methods: processKeyPress(), collisionHandler()    

    Description:
 * 
 * Entry Point for PPCourseWork project
 * 
 * In addtion to the MainMenu class there are 3 main groups of classes in the project - Clients,Robots and Brains.
 * The MainMenu class controls which client is active.
 * 
 * Clients inherit from BaseClient abstract class
 * BaseClient provides a method to return to the main menu at any point by pressing Esc
 * Derived clients create environments for robots to operate in and send keyboard inputs to the robots
 * 
 * Robots inherit from BaseRobot abstract class
 * BaseRobot defines properties and movement methods common to all robots and a basic reporting function
 * Derived robots contain additonal methods for moving the robot around the console, and handling input from the client
 * Robot behaviour is determined by its brain type
 * This is an example of composition. i.e. Robot has a Brain
 * 
 * Brains inherit from BaseBrain abstract class
 * BaseBrain properties define which robot the brain instance belongs to and a base method for processing input sent to the robot
 * Derived Brains contain methods for robot behaviour. E.g. some robots will perform pre-programmed maneuvers, others move randomly
 * and some will be under direct control of the user.
 * 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PPCourswork
{
    class Program
    {
        static void Main(string[] args)
        {

            MainMenu menu = new MainMenu();

            menu.showMenu();


        }
    }
}
