class Task3
{
    public void Execute()
    {
        Console.Write("Enter a string for Caesar cipher encryption: ");
        string inputText = Console.ReadLine();
        Console.Write("Enter the shift value: ");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = CaesarCipher.Encrypt(inputText, shift);
        string decryptedText = CaesarCipher.Decrypt(encryptedText, shift);

        Console.WriteLine($"Encrypted text: {encryptedText}");
        Console.WriteLine($"Decrypted text: {decryptedText}");
    }
}

class CaesarCipher
{
    public static string Encrypt(string input, int shift)
    {
        char[] buffer = input.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            if (char.IsLetter(buffer[i]))
            {
                char letter = buffer[i];
                char offset = char.IsLower(letter) ? 'a' : 'A';
                buffer[i] = (char)((((letter + shift) - offset) % 26) + offset);
            }
        }
        return new string(buffer);
    }

    public static string Decrypt(string input, int shift)
    {
        return Encrypt(input, 26 - shift);
    }
}