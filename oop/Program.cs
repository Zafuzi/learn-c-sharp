
using System.Runtime.Serialization;

var p1 = new Person("Billy", "Bob", new DateOnly(1984, 12, 22));
p1.Pets.Add(new Cat("Grep"));
var p2 = new Person("Sally", "Sue", new DateOnly(1977, 7, 7));
p2.Pets.Add(new Dog("Grok"));
var p3 = new Person("Jefferey", "James", new DateOnly(1967, 6, 7));
p3.Pets.Add(new Dog("Skim"));
p3.Pets.Add(new Cat("Milk"));

List<Person> people = [p1, p2, p3];

IEnumerable<Person> peopleOlderThanFifty =
	from person in people
	where person.Birthday.Year < 1976
	select person;

foreach (var person in peopleOlderThanFifty)
{
	Console.WriteLine(person);
}

public abstract class Pet(string firstName)
{
	public string First { get; } = firstName;

	public abstract string MakeNoise();

	public override string ToString() => $"{GetType().Name}\t{First}\t{MakeNoise()}";
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
	public string First { get; } = firstName;
	public string Last { get; } = lastName;
	public DateOnly Birthday { get; } = birthday;
	public List<Pet> Pets { get; } = new();

	public override string ToString()
	{
		string message = $"Birthday | First | Last\n{Birthday} | {First} | {Last}";
		if (this.Pets.Count > 0)
		{
			message += $"\nPets\tType\tName\tSays";
			foreach (var pet in Pets)
			{
				message += $"\n\t{pet}";
			}
		}

		return message;
	}
}

public class Cat(string firstname) : Pet(firstname)
{
	public override string MakeNoise() => "Meow";
}

public class Dog(string firstname) : Pet(firstname)
{
	public override string MakeNoise() => "Woof";
}