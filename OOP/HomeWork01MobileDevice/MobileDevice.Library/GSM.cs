using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    //Internal, so the user application can't access this class,
    //Only the test classes (GSMTest, GSMCallHistoryTest) are accesssible by the users.
    internal class GSM
    {
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        private Display display;
        private Battery battery;
        //The reqired static field for the iPhone 4S
        private static GSM iPhone4S = new GSM(
            "iPhone 4S", "Apple", 199m, "Steve Jobs"
            , new Display(640, 960, 16777216),
            new Battery("APN: 616-0579", 300, 14, BatteryType.LiIon));
        //The data is actually correct
        //well, the owner isn't Steve Jobs. ( or is it? :P )

        //Declaring the list of made calls.
        private List<Call> callList;

        //Here is the given price per minute for a call
        private decimal pricePerMinute = 0.37m;


        //CONSTRUCTORS

        //General purpose constructor
        public GSM(string model, string manifacturer, decimal price, string owner,
            Display display, Battery battery)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.display = new Display(display);
            this.battery = new Battery(battery);

            //Creating the call list
            callList = new List<Call>();
        }

        //Mininum requirements constructor
        public GSM(string model, string manifacturer)
            : this(model, manifacturer, 0m, null, new Display(), new Battery())
        {

        }

        //END CONSTRUCTORS

        //METHODS

        //Adds a call to the call list.
        public void AddCall( Call call)
        {
            this.CallList.Add(call);
        }

        //Removes a call from the list, by a given index
        public void RemoveCall(int index)
        {
            if (callList.Count > index)
            {
                callList.RemoveAt(index);
            }
        }

        //Removes a call from the list by a given call
        public void RemoveCall(Call call)
        {
            callList.Remove(call);
        }

        //Clears all calls
        public void ClearCalls()
        {
            callList.Clear();
        }


        // Calculates the total price of the calls in the list
        public decimal CallsPrice()
        {
            
            int totalDuration = 0;

            //Calculates the total duration of the calls in the list
            foreach (var call in callList)
            {
                totalDuration += call.Duration;
            }

            //Converts the total duration in minutes and calculates the total price
            return ( ( (decimal)totalDuration )/60 ) * pricePerMinute;
        }

        

        //End METHODS

        // PROPERTIES

        public string Model
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
            }
        }//End Model propertie

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)))
                {
                    this.manifacturer = value;
                }
            }
        }//End Manifacturer propertie

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                //The price can be zero or positive
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    this.price = 0m;
                }
            }
        }//End Price propertie

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                //Checks if the strings is empty
                if (!(string.IsNullOrEmpty(value)))
                {
                    this.owner = value;
                }
                else
                {
                    this.owner = "Unknown";
                }
            }
        }//End Owner propertie


        //This is read-only, because the specs of the iphone are already implemented
        public static GSM IPhone4s
        {
            get
            {
                return iPhone4S;
            }
        }//Ends the static IPhone4s propertie

        public List<Call> CallList
        {
            set
            {
                this.callList = value;
            }
            get
            {
                return this.callList;
            }
        }//End CallList propertie


        public override string ToString()
        {
            return string.Format(
                "Model: {0}\nManifacturer: {1}\nPrice: {2:C2}\nOwner: {3}\n" +
            "Display:\n{4}\n====\nBattery:\n{5}\n====\n",
            Model, Manifacturer, Price, Owner, display.ToString(), battery.ToString());
        }
    }
}
        //private string model;
        //private string manifacturer;
        //private decimal price;
        //private string owner;
        //private Display display;
        //private Battery battery;