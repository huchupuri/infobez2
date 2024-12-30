using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите ключ: ");
        string key = Console.ReadLine();
        Console.Write("Введите строку для шифрования: ");
        string input = Console.ReadLine();

        string encryptedText = Encrypt(input, key);

        Console.Write("Зашифрованное сообщение: ");
        Console.WriteLine(encryptedText);
    }

    static string Encrypt(string text, string key)
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int alphabetLength = alphabet.Length;

        text = text.ToLower();
        key = key.ToLower();

        char[] result = new char[text.Length];

        for (int i = 0, j = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            int charIndex = alphabet.IndexOf(currentChar);
            if (charIndex == -1)
            {
                result[i] = currentChar;
                continue;
            }
            int keyIndex = alphabet.IndexOf(key[j % key.Length]);
            int encryptedIndex = (charIndex + keyIndex) % alphabetLength;
            result[i] = alphabet[encryptedIndex];
            j+=1; 
        }

        return new string(result);
    }
}
