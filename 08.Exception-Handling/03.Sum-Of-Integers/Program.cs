
List<int> numbers = new List<int>();

string[] inputArray = Console.ReadLine().Split(" ");

foreach (var item in inputArray)
{
    try
    {
        int number = int.Parse(item);

        numbers.Add(number);
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{item}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{item}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{item}' processed - current sum: {numbers.Sum()}");
    }
}

Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");