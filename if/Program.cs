using System;

namespace if
{
    class Program
{
    static void Main(string[] args)
    {
        string stnumber = Console.ReadLine();
        int number = Convert.ToInt32(stnumber);

        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        if(number %2!=0)
        {
            Console.WriteLine("Odd");
        }
        Console.ReadKey();

    
        }
}
}
