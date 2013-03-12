using System;

class ReadAgeWriteAgePlus10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your current age");
        int age = 10 + int.Parse(Console.ReadLine());
        Console.WriteLine(age);
    }
}
