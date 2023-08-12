namespace day2_middle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("How old are you?");
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are {age} years old");
        }
    }
}