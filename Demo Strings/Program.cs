using System;
namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Nhat";
            var lastName = "Dang";
            
            var fullName = firstName + " " + lastName;
            
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);
            
            var names = new string[3] { "Lam", "Thinh", "Chien" };
            var formattedNames= string.Join(",",names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\\folder1\\folder2
c:\\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
