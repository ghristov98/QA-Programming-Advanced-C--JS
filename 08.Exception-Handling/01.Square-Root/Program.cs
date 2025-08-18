
try
{
    int number = int.Parse(Console.ReadLine());

    if (number < 0)
    {
        throw new ArgumentException("Invalid number.");
    }

    double sqrt = Math.Sqrt(number);
    Console.WriteLine(sqrt);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Goodbye.");
}