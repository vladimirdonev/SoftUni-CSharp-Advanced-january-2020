using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace DefiningClasses
{
    class DateModifier
    {
        public void SumofDays(string Start,string End)
        {
            string[] Startdate = Start.Split(" ");
            string[] Enddate = End.Split(" ");
            int startyear = int.Parse(Startdate[0]);
            int endtyear = int.Parse(Enddate[0]);
            int startmonts = int.Parse(Startdate[1]);
            int endmonts = int.Parse(Enddate[1]);
            int startdays = int.Parse(Startdate[2]);
            int enddays = int.Parse(Enddate[2]);
            int years = Math.Abs(startyear - endtyear);
            int monts = Math.Abs(startmonts - endmonts);
            int days = Math.Abs(startdays - enddays);
            DateTime first = new DateTime(startyear, startmonts, startdays);
            DateTime second = new DateTime(endtyear, endmonts, enddays);
            double sum = (first - second).TotalDays;
            sum = Math.Abs(sum);
            Console.WriteLine(sum);
        }
    }
}
