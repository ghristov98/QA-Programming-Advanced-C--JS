Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

string resource = Console.ReadLine(); 

while (resource != "stop")
{

    int quantity = int.Parse(Console.ReadLine()); //количество от полезното изкопаемо

    if (resourcesQuantity.ContainsKey(resource))
    {
        resourcesQuantity[resource] += quantity;
    }
    else
    {
        resourcesQuantity.Add(resource, quantity);
    }

    resource = Console.ReadLine();
}


foreach (KeyValuePair<string, int> entry in resourcesQuantity)
{
    Console.WriteLine(entry.Key + " -> " + entry.Value);
}