/*
List<string> names = new List<string> { "Sally", "Sue", "Sarah" };

names.Add("Billy");
names.Add("Bob");
names.Add("Brad");

Console.WriteLine($"Names has {names.Count} entries.");

int index = 0;
foreach (string name in names)
{
	Console.WriteLine($"{index} - {name.ToUpper()}");
	index++;
}

Console.WriteLine($"FIRST ENTRY: {names[0]}");
Console.WriteLine($"SECOND FROM LAST ENTRY: {names[^2]}");
Console.WriteLine($"LAST ENTRY: {names[^1]}");
*/

var numbers = new int[] { 0, 100, 23, 235, 58, 18, 013285, 784, 48 };

Console.WriteLine($"I found 100 at index {numbers.IndexOf(100)}.");
numbers.Sort();
Console.WriteLine($"I found 100 at index {numbers.IndexOf(100)} after sort.");

foreach (int number in numbers)
{
	Console.WriteLine(number);
}