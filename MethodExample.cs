using System;

namespace _01.usingMethods
{
    class MethodExample
    {
        static void PrintLogo()
        {
            Console.WriteLine("Telerik corp.");
            Console.WriteLine("www.telerik.com");
            //this is a method
        }
        static void PrintAcademyLogo() 
        {
            Console.WriteLine("Telerik Academy");
            Console.WriteLine("Part Of");
            PrintLogo(); //We call he the first Method PrintLogo();
        }
        static void Main() 
        {
            PrintAcademyLogo();
            //this is a invoke of a method, callint a method!

        }
    }
}
