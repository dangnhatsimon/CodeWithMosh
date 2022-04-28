using Demo_Classes.Math;
using System;
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var nhat = new Person();
            nhat.FirstName = "Dang";
            nhat.LastName = "Nhat";
            nhat.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
} 