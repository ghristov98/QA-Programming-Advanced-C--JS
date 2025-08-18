﻿string[] words = Console.ReadLine() 
                  .Split(" ");      



Dictionary<string, int> wordsCount = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordWithLowerCase = word.ToLower();

    if (wordsCount.ContainsKey(wordWithLowerCase))
    {
        wordsCount[wordWithLowerCase]++;
    }
    else
    {
        wordsCount.Add(wordWithLowerCase, 1);
    }
}


foreach (string key in wordsCount.Keys)
{
    
    int occurrences = wordsCount[key];
    if (occurrences % 2 != 0)
    {
        Console.Write(key + " ");
    }
}