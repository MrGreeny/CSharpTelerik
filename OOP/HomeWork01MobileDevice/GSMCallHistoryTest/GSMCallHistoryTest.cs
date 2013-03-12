using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MobileDevice.Library;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("XCZ-55", "Siemens", 20m, "Futurama Fry", 
                new Display(200, 200, 256), new Battery("ABZ", 14,2,BatteryType.LiIon) );

            gsm.AddCall(new Call(DateTime.Now, 987123, 10));
            gsm.AddCall(new Call(DateTime.Now, 18923, 120));
            gsm.AddCall(new Call(DateTime.Now, 8747121, 400));
            gsm.AddCall(new Call(DateTime.Now, 193144, 1212));

            foreach (var call in gsm.CallList)
            {
                Console.WriteLine( call.ToString() );
            }

            Console.WriteLine("Total call price:");
            Console.WriteLine( gsm.CallsPrice() );

            int longestCallDuration = 0;
            Call longestCall = new Call();
            foreach (var call in gsm.CallList)
            {
                if (call.Duration > longestCallDuration)
                {
                    longestCallDuration = call.Duration;
                    longestCall = call;
                }
            }

            gsm.RemoveCall(longestCall);
            Console.WriteLine("Call Removed");



            gsm.ClearCalls();
            Console.WriteLine("Call history");
            foreach (var call in gsm.CallList)
            {
                Console.WriteLine(call.ToString());
            }

            Console.WriteLine("Total call price:");
            Console.WriteLine(gsm.CallsPrice());

        }
    }
}
