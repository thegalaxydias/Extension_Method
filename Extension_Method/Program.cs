using System;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            value.ExtensionMethod();
        }


    }
    public static class Extension
    {
        public static void ExtensionMethod(this int value)
        {
            Console.WriteLine("Value of your variable is: " + value);
        }
    }


     
}

