List<string> names = new List<string> { "Sally", "Sue", "Sarah" };

names.Add("Billy");
names.Add("Bob");
names.Add("Brad");

Console.WriteLine($"Names has {names.Count()} entries.");

int index = 0;
foreach (string name in names)
{
	Console.WriteLine($"{index} - {name.ToUpper()}");
	index++;
}

Console.WriteLine($"FIRST ENTRY: {names[0]}");
Console.WriteLine($"THIRD ENTRY: {names[2]}");
Console.WriteLine($"LAST ENTRY: {names[names.Count() - 1]}");