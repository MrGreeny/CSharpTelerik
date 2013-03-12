using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the company name");
            string companyName = Console.ReadLine();

            Console.WriteLine("Please enter the company adress");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Please enter the company phone #");
            uint companyPhone = uint.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the company fax #");
            uint companyFax = uint.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the company web site");
            string companyWebSite = Console.ReadLine();
            
            Console.WriteLine("Please enter the manager's first name");
            string managerFirstName = Console.ReadLine();
            
            Console.WriteLine("Please enter the manager's last name");
            string managerLastName = Console.ReadLine();
            
            Console.WriteLine("Please enter the manager's age");
            ushort managerAge = ushort.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the manager's phone #");
            uint managerPhone = uint.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Company Name:        | {0,-10}", companyName);
            Console.WriteLine("Company Address:     | {0,-10}", companyAddress);
            Console.WriteLine("Company Phone:       | {0,-10}", companyPhone);
            Console.WriteLine("Company Fax:         | {0,-10}", companyFax);
            Console.WriteLine("Company website:     | {0,-10}", companyWebSite);
            Console.WriteLine("Manager's first name:| {0,-10}", managerFirstName);
            Console.WriteLine("Manager's last name: | {0,-10}", managerLastName);
            Console.WriteLine("Manager's age:       | {0,-10}", managerAge);
            Console.WriteLine("Manager's phone:     | {0,-10}", managerPhone);

        }

    }
}
