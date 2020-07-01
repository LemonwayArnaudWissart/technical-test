using System;
using ConsoleApp.ServiceReference;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            WebServiceSoap svc = new WebServiceSoapClient();
            Console.WriteLine("Here's the result for Fibonacci(10)");
            Console.WriteLine();
            Console.WriteLine(svc.Fibonacci(10));
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
