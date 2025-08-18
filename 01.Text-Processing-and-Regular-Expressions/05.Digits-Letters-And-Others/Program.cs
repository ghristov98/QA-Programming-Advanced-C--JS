
using System.Text;

string input = Console.ReadLine();

string letters = "";
string digits = "";
string specialCharacters = "";

foreach (char currentSymbol in input)
{
    if (char.IsLetter(currentSymbol))
    {
        letters += currentSymbol;
    }
    else if (char.IsDigit(currentSymbol))
    {
        digits += currentSymbol;
    }
    else
    {
        specialCharacters += currentSymbol;
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(specialCharacters);