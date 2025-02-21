namespace _16_11
{
    class Task6Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine() ?? "";

            int wordCount = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;
            Console.WriteLine($"Word count: {wordCount}");
        }
    }
}