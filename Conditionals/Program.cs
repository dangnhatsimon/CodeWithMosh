using System;
namespace Conditionals
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //    int hour = 10;
            //    if(hour>0 && hour<12)
            //    {
            //        Console.WriteLine("It's morning");
            //    }
            //    else if (hour>12 && hour<18)
            //    {
            //        Console.WriteLine("It's afternoon");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It's evening");
            //     }
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach");
                    break ;
                default:
                    Console.WriteLine("I dont's understand that season!");
                    break;
            }
        }  
    }


}
