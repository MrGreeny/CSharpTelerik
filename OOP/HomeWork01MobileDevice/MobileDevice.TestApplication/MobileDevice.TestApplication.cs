using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileDevice.Library;

namespace MobileDevice.TestApplication
{
    class MobileDeviceTestApplication
    {
        static void Main(string[] args)
        {
            
            //Exercise 7
            Console.WriteLine("GSMTest");
            //Creating instance of the GSMTest class
            GSMTest test = new GSMTest();
            //Displays the info for the entered phones
            test.DisplayInfo();
            //Displays the iPhone 4S specs
            test.DisplayIphoneSpecs();


            //Exercise 12
            Console.WriteLine("GSMCallHystoryTest");
            //Creating an instance of the GSMCallHistoryTest
            GSMCallHistoryTest callTest = new GSMCallHistoryTest();
            //Adding some calls
            callTest.AddSomeCalls();

            //Displays toe information for the added calls
            callTest.DisplayInformation();
            //Displays the total price of the calls
            callTest.DisplayTotalPrice();

            //Removes the longest call
            callTest.RemoveLongestCall();
            //Displays the updated price
            callTest.DisplayTotalPrice();

            //Clears all the calls
            callTest.ClearCalls();
            //Displays toe information for the calls (none)
            callTest.DisplayInformation(); 
        }
    }
}
