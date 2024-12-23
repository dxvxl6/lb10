using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\artem\\OneDrive\\Рабочий стол\\ля.txt";
        try
        {
            string content = File.ReadAllText(filePath);
            int maxLength = FindLongestXSequence(content);
            Console.WriteLine($"Длина самой длинной последовательности символов 'X': {maxLength}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
    static int FindLongestXSequence(string str)
    {
        int maxCount = 0; 
        int currentCount = 0; 

        foreach (char c in str)
        {
            if (c == 'X')
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 0; 
            }
        }
        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        return maxCount;
    }
}