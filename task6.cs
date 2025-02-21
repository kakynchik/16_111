class Task6
{
    public void Execute()
    {
        Console.Write("Enter a text for sentence case conversion: ");
        string paragraph = Console.ReadLine();
        string sentenceCaseText = SentenceCase.ConvertToSentenceCase(paragraph);
        Console.WriteLine($"Converted text: {sentenceCaseText}");
    }
}

class SentenceCase
{
    public static string ConvertToSentenceCase(string input)
    {
        string[] sentences = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
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