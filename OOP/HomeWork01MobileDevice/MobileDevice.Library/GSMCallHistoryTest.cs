using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    //THe test class
    //The class is public and can be accessed by the user to test features
    public class GSMCallHistoryTest
    {
        //Declaring a mobile device
        private GSM gsm;

        //One and only constructor
        public GSMCallHistoryTest()
        {
            //Creating the mobile device
            this.gsm = new GSM("XCZ-55", "Siemens", 20m, "Futurama Fry",
                    new Display(200, 200, 256), new Battery("ABZ", 14, 2, BatteryType.LiIon));
        }

        public void AddSomeCalls()
        {
            //Adding some calls
            this.gsm.AddCall(new Call(DateTime.Now, "98-71-23", 10));
            this.gsm.AddCall(new Call(DateTime.Now, "0881892313", 120));
            this.gsm.AddCall(new Call(DateTime.Now, "98747121", 400));
            this.gsm.AddCall(new Call(DateTime.Now, "+359 193144", 1212));
            this.gsm.AddCall(new Call(DateTime.Now, "874812", 230));
        }

        //Displays the details of the calls stored in the gsm
        public void DisplayInformation()
        {
            foreach (var call in this.gsm.CallList)
            {
                Console.WriteLine(call.ToString());
            }
        }

        //Displays the price of the calls stored in the gsm
         public void DisplayTotalPrice()
        {
            Console.WriteLine("Total call price: {0:C2}\n",gsm.CallsPrice());

        }

        //Removes the longest call
        public void RemoveLongestCall()
        {
            //Stores the call duraton
            int longestCallDuration = 0;
            Call longestCall = new Call();

            //Iterates trough the stored calls
            foreach (var call in gsm.CallList)
            {
                //finds the longest call
                if (call.Duration > longestCallDuration)
                {
                    //stores the longest call duration
                    longestCallDuration = call.Duration;
                    //Stores the longest call
                    longestCall = call;
                }
            }
            //Removes the call from the stored calls and displays a message
            gsm.RemoveCall(longestCall);
            Console.WriteLine("Call Removed");
        }

        //Clears all the calls
        public void ClearCalls()
        {
            this.gsm.ClearCalls();
        }

    }
}
