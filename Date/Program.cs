﻿using System;
namespace Date
{
    class Program
    {
        static void Main (string [] args)
        {
            var dateTime = new DateTime(2015,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: "+now.Minute);

            var tomorrow = now.AddDays (1);
            var yesterday = now.AddDays (-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpan);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);
              
            Console.WriteLine("Minutes: "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+timeSpan.TotalMinutes);

            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("To string " + timeSpan.ToString());

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        
        }
    }
}