
string partToRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(partToRemove))
{
    int startIndex = text.IndexOf(partToRemove);
    int lenght = partToRemove.Length;

    text.Remove(startIndex, lenght);
}
