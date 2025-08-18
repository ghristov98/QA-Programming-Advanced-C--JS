using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+[A-Z][a-z]+";

string input = Console.ReadLine();

MatchCollection names =  Regex.Matches(input, pattern);

foreach (var currentName in names)
{
    Console.Write(currentName + " ");
}
