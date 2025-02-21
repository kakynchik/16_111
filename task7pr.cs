namespace _16_11
{
    class Task7Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine() ?? "";

            string result = string.Join(" ", input.Split().Select(word => new string(word.Reverse().ToArray())));
            Console.WriteLine($"Reversed words: {result}");
        }
    }
}