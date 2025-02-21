namespace _16_11
{
    class Task8Pr
    {
        public void Execute()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine() ?? "";

            int vowelCount = input.Count(c => "aeiouAEIOUаеєиіїоуюяАЕЄИІЇОУЮЯ".Contains(c));
            Console.WriteLine($"Vowel count: {vowelCount}");
        }
    }
}