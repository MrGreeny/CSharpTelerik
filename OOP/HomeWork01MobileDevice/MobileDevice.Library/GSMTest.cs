using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobileDevice.Library
{
    //The class is public and can be accessed by the user to test features
    public class GSMTest
    {
        
        private GSM[] gsmArray = new GSM[5];

        //One constructor is needed for the test class
        public GSMTest()
        {         
            //Some test phones 
            gsmArray[0] = new GSM("Asha", "Nokia");
            gsmArray[1] = new GSM("3310", "Nokia");
            gsmArray[2] = new GSM("Nexus III", "Google", 600m, "Google corp.", new Display(640, 480, 1064), new Battery("Sony XYZ", 200, 2, BatteryType.NiMh));
            gsmArray[3] = new GSM("Galaxy", "Samsung", 400m, "Jin-Lu-Pan", new Display(400,800,20000), new Battery("AX-812", 100, 14, BatteryType.NiCd));
            gsmArray[4] = new GSM("C-200", "Siemens", 4m, "Homer Simpson", new Display(400, 300, 2), new Battery());
        }


        //Displays the required info
        //1. All the phone specs
        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        //2. The iPhone 4S specifications
        public void DisplayIphoneSpecs()
        {
        
            Console.WriteLine(GSM.IPhone4s.ToString());
        }

        //Read-only propertie
        private GSM[] GsmArray
        {
            get
            {
                return this.gsmArray;
            }
        }//end GsmArray propertie
        

        public override string ToString()
        {
            string result = "";

            foreach (var gsm in gsmArray)
            {
                result += gsm.ToString() + "\n";
            }

            return result;
        }

    }
}
