namespace DemoArrays
{
    class Program
    {
        static void Main (string [] args)
        {
            //var numbers = new int[3];
            //numbers[0] = 1;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);
            //Console.WriteLine(flags[2]);

            //var names = new string[3] { "Chien", "Thinh", "Lam" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine ("Length: "+numbers.Length);
            
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine ("Index of  9: "+index);

            Array.Clear (numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine (n);
            Console.WriteLine("\n");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
                Console.WriteLine(n);

            
            Array.Sort (numbers);
            Console.WriteLine("Effect of Sort ()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            Array.Reverse (numbers);
            Console.WriteLine("Effect of Reverse ()");
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
    }
}