
string[] arr = Console.ReadLine().Split(" ");

string result = "";

for (int i = 0; i < arr.Length; i++)
{
    string currentText = arr[i];

    string concatText = "";

    for (int count = 0; count < currentText.Length; count++)
    {
        concatText += currentText;

    }

    result += concatText;
}
Console.WriteLine(result);