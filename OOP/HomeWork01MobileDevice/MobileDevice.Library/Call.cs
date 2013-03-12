using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    //Internal, so the user application can't access this class,
    //Only the test classes (GSMTest, GSMCallHistoryTest) are accesssible by the users.
    internal class Call
    {
        private DateTime dateTime;
        private string dialedPhone;
        private int duration; //seconds

        //Complete constructor
        public Call(DateTime dateTime, string dialedPhone, int duration)
        {
            this.DateTime = dateTime;
            this.DialedPhone = dialedPhone;
            this.Duration = duration;
        }
        //Default constructor
        public Call() : this(DateTime.Now, null, 0)
        {
           
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                if (value != null)
                {
                    this.dateTime = value;
                }
            }
        }//End DateTime property

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    this.dialedPhone = value;
                }
                else
                {
                    this.dialedPhone = "Unkonwn number";
                }
            }
        }//End DialedPhone property

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                //Duration can be only positive
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    this.duration = 0;
                }
            }
        }//End Duration property

        public override string ToString()
        {
            return string.Format
                ("Date and time: {0}\nDialed phone :{1}\nDuration: {2} min.\n",
                DateTime, DialedPhone, Duration);
        }

    }
}
