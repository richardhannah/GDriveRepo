/*
    File:   KungFuBot.cs
    Version:    1.0
    Date: 13th May 2013
    Author: Richard Ferguson-Hannah

    Namespace:  PPCourswork
    Public Properties: RHouseFX, SweepFX, PunchFX, MusicFX, SwooshFX
 *  Public Methods:  

    Description:
    
 *  Sound effects for the Kung Fu Client
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;

namespace PPCourswork
{
    public class SFX
    {
        private WindowsMediaPlayer rHouseFX;
        private WindowsMediaPlayer sweepFX;
        private WindowsMediaPlayer punchFX;
        private WindowsMediaPlayer musicFX;
        private WindowsMediaPlayer swooshFX;

        public WindowsMediaPlayer RHouseFX{
            get { return rHouseFX; }
            
        }

        public WindowsMediaPlayer SweepFX
        {
            get { return sweepFX; }

        }

        public WindowsMediaPlayer PunchFX
        {
            get { return punchFX; }

        }

        public WindowsMediaPlayer MusicFX
        {
            get { return musicFX; }

        }

        public WindowsMediaPlayer SwooshFX
        {
            get { return swooshFX; }

        }



        public SFX()
        {
            //load sfx

            rHouseFX = new WMPLib.WindowsMediaPlayer();
            
            sweepFX = new WMPLib.WindowsMediaPlayer();
            
            punchFX = new WMPLib.WindowsMediaPlayer();

            musicFX = new WMPLib.WindowsMediaPlayer();

            swooshFX = new WMPLib.WindowsMediaPlayer();
            
            

            
       
        }

    }
}
