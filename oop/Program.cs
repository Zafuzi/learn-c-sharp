
var p1 = new Person("Billy", "Bob", new DateOnly(1984, 12, 22));
var p2 = new Person("Sally", "Sue", new DateOnly(1977, 7, 7));
var p3 = new Person("Jefferey", "James", new DateOnly(1967, 6, 7));

List<Person> people = [p1, p2, p3];

IEnumerable<Person> peopleOlderThanFifty =
	from person in people
	where person.Birthday.Year < 1976
	select person;

foreach (var person in peopleOlderThanFifty)
{
	Console.WriteLine($"{person.First} {person.Last} {person.Birthday}");
}

public class Person(string firstName, string lastName, DateOnly birthday)
{
	public string First { get; } = firstName;
	public string Last { get; } = lastName;
	public DateOnly Birthday { get; } = birthday;
}
