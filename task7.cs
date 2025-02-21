class Task7
{
    public void Execute()
    {
        Console.Write("Enter a text for inappropriate words filtering: ");
        string text = Console.ReadLine();
        string[] forbiddenWords = { "die" };
        string filteredText = InappropriateWordsFilter.FilterInappropriateWords(text, forbiddenWords);
        int replacementsCount = InappropriateWordsFilter.CountReplacements(text, forbiddenWords);
        Console.WriteLine($"Filtered text: {filteredText}");
        Console.WriteLine($"Statistics: {replacementsCount} replacements.");
    }
}

class InappropriateWordsFilter
{
    public static string FilterInappropriateWords(string input, string[] forbiddenWords)
    {
        string result = input;
        foreach (string word in forbiddenWords)
        {
            result = result.Replace(word, new string('*', word.Length));
        }
        return result;
    }

    public static int CountReplacements(string input, string[] forbiddenWords)
    {
        int count = 0;
        foreach (string word in forbiddenWords)
        {
            count += (input.Length - input.Replace(word, "").Length) / word.Length;
        }
        return count;
    }
}