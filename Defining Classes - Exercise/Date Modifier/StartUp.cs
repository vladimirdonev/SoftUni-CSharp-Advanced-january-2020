using System;
using System.Globalization;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string Startdate = Console.ReadLine();
            string EndDate = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            dateModifier.SumofDays(Startdate, EndDate);
        }
    }
}
