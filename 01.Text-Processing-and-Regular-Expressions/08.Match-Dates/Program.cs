using System.Text.RegularExpressions;

string patters = @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\<separator>(?<year>\d{4})\b";

string input = Console.ReadLine();

MatchCollection dates = Regex.Matches(input, patters);

foreach (Match item in dates)
{
    string day = item.Groups["day"].Value;
    string month = item.Groups["month"].Value;
    string year = item.Groups["year"].Value;

    Console.WriteLine($"Day : {day}, Month: {month}, Year: {year}");
}
