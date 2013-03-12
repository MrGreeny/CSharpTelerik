using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    //Internal, so the user application can't access this class,
    //Only the test classes (GSMTest, GSMCallHistoryTest) are accesssible by the users.
    internal class Display
    {
        private int displayWidth; //in pixels
        private int displayHeight; //in pixels
        private int numberOfColors;

        //General purpose constructor
        public Display(int displayWidth, int displayHeight, int numberOfColors)
        {
            this.DisplayWidth = displayWidth;
            this.DisplayHeight = displayHeight;
            this.NumberOfColors = numberOfColors;
        }

        //Default constructor
        public Display() 
            
            : this (0,0,0)
        {
        }

        //Copy constructor
        public Display(Display display) 
            : this(display.DisplayWidth, display.DisplayHeight, display.NumberOfColors)
        {
        }


        protected int DisplayWidth
        {
            get
            {
                return this.displayWidth;
            }
            set
            {
                //Can be only positive
                if (value > 0)
                {
                    this.displayWidth = value;
                }
                else
                {
                    this.displayWidth = 0;
                }
            }
        }//End DisplayWidth property

        protected int DisplayHeight
        {
            get
            {
                return this.displayHeight;
            }
            set
            {
                //Can be only positive
                if (value > 0)
                {
                    this.displayHeight = value;
                }
                else
                {
                    this.displayHeight = 0;
                }
            }
        }//End DisplayHeight property

        protected int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                //Can be only positive
                if (value > 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    this.numberOfColors = 0;
                }
            }
        }//End NumberOfColors property

        public override string ToString()
        {
            return string.Format("Size:{0}x{1}px\nColors: {2}", 
                DisplayWidth, DisplayHeight, NumberOfColors);
        }
    }
}