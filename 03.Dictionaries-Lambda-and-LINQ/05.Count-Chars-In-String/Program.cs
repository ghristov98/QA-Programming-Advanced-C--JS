string text = Console.ReadLine();

Dictionary<char, int> countSymbols = new Dictionary<char, int>();


foreach (char symbol in text)
{
    if (symbol == ' ')
    {
        continue;
    }

    if (countSymbols.ContainsKey(symbol))
    {
       countSymbols[symbol]++;
    }
    else
    {
        countSymbols.Add(symbol, 1);
    }
}

foreach (KeyValuePair<char, int> pair in countSymbols)
{
    Console.WriteLine(pair.Key + " -> " + pair.Value);
}