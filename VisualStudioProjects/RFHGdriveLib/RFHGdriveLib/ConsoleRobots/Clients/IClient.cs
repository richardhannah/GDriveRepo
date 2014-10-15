/*
    File:   IClient.cs
    Version:    1.0
    Date:   30th April 2013.
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: n/a
 *  Public Methods: runClient(),clientMain()    

    Description:
 *  This interface is not required - in this program the BaseClient is the interface which is being
 *  progarammed to
 *  http://stackoverflow.com/questions/383947/what-does-it-mean-to-program-to-an-interface
 *  
 *  Retained as a note
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPCourswork
{
    interface IClient
    {
        void runClient();
     
        ConsoleKeyInfo clientMain();
    }
}
