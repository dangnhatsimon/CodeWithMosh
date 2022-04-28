using System;
namespace Iterations
{
    class Program
    {
        static void Main(string [] args)
        {
            //for (var i=1; i<=10;i++)
            //{
            //    if (i%2 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //while (true)
            //{
            //    Console.WriteLine("Type your name: ");
            //    var input = Console.ReadLine();
            //    if (!String.IsNullOrWhiteSpace (input))
            //    {
            //        Console.WriteLine("@Echo: "+input);
            //        continue;
            //    }
            //    break;
            //} 
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var i=0; i <passwordLength; i++)
                buffer[i] = (char)('a'+random.Next(0,26));
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}