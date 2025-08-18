
List<int> tenNumbers = new List<int>();

int start = 1;

while (tenNumbers.Count < 10)
{
    try
    {
        int currentNumber = ReadNumber(start, 100);

        tenNumbers.Add(currentNumber);

        start = currentNumber; 
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine($"Your number is not in range {start} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
}

Console.WriteLine(string.Join(", ", tenNumbers));


int ReadNumber(int start, int end)
{
    int number = int.Parse(Console.ReadLine());

    if (number <= start || number >= end)
    {
        throw new ArgumentOutOfRangeException();
    }

    return number;
}