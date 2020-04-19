#nullable enable
using System;
using static System.Console;

namespace NullHandling
{
    class Address 
    {
        public string? Building;
        public string Street;
        public string City;
        public string Region;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null;
            int? thisCouldBeNull = null;
            printNullableInt(thisCouldBeNull);
            thisCouldBeNull = 7;
            printNullableInt(thisCouldBeNull);
        }
        
        
        static void printNullableInt(int? a)
        {
           WriteLine(a);
           WriteLine(a.GetValueOrDefault()); 
        }
    }
}
