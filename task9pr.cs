namespace _16_11
{
    class Task9Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter a text:");
            string text = Console.ReadLine() ?? "";

            Console.WriteLine("Enter substring to search:");
            string substring = Console.ReadLine() ?? "";

            int count = (text.Length - text.Replace(substring, "").Length) / substring.Length;
            Console.WriteLine($"Substring count: {count}");
        }
    }

}