using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuotedQuotations
{
    class QuotedQuotations
    {
        static void Main(string[] args)
        {
            //Exercise 08
            string quotedQuotations = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(quotedQuotations);  //The "use" of quotations causes difficulties

            string unquotedQuotations = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine(unquotedQuotations);  //The "use" of quotations causes difficulties
        }
    }
}
