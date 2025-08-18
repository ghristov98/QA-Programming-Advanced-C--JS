List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

SortedDictionary<int, int> countOccurences = new SortedDictionary<int, int>();

foreach (int number in numbers)
{
    if (countOccurences.ContainsKey(number))
    {
        
        countOccurences[number]++;
    }
    else
    {
        countOccurences.Add(number, 1);
    }
}

foreach (KeyValuePair<int, int> pair in countOccurences)
{

    Console.WriteLine(pair.Key + " -> " + pair.Value);
}