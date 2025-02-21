namespace _16_11
{
    class Task6
    {
        public void Execute()
        {
            Console.Write("Enter a text for sentence case conversion: ");
            string? paragraph = Console.ReadLine();
            string sentenceCaseText = SentenceCase.ConvertToSentenceCase(paragraph ?? string.Empty);
            Console.WriteLine($"Converted text: {sentenceCaseText}");
        }
    }

    class SentenceCase
    {
        public static string ConvertToSentenceCase(string input)
        {
            var sentences = input.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
                if (sentences[i].Length > 0)
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }

            return string.Join(". ", sentences) + ".";
        }
    }
}