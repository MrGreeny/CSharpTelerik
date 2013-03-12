using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    
    public enum BatteryType
    {
        LiIon,
        NiMh,
        NiCd,
    }
    
    //Internal, so the user application can't access this class,
    //Only the test classes (GSMTest, GSMCallHistoryTest) are accesssible by the users.
    internal class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType batteryType;

        //full constructor
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.BatteryType = batteryType;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        //default constructor
        public Battery() 
            : this(null, 0,0, 0)
        {         
        }

        //Copy constructor
        public Battery(Battery battery)
            : this(battery.Model, battery.HoursIdle, battery.HoursTalk, battery.BatteryType)
        {
        }

        //Property of the hoursIdle field
        protected int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value > 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    this.hoursIdle = 0;
                }
            }
        }//End HoursIdle property

        protected int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                //The talk hours can't be more or equal to the idle hours
                if (value > 0 && value <= HoursIdle)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    this.hoursTalk = 0;
                }
            }
        }//End HoursTalk property


        protected string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    this.model = value;
                }
                else
                {
                    this.model = "Unknown model";
                }
            }
        }//End Model property

        protected BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }//End BatteryType property

        public override string ToString()
        {
            return string.Format(
                "Model: {0}\nHours idle: {1}\nHours talk: {2}\nType: {3}",
                Model, HoursIdle, HoursTalk, BatteryType);
        }
    }
}