List<int> scores = [97, 92, 81, 60, 10, 20, 30, 40, 50, 88, 89, 73, 100, 99, 97, 93, 82];

IEnumerable<string> scoreQuery =
	from score in scores
	where score > 70
	orderby score ascending
	select $"The score is {score}";

foreach (string s in scoreQuery)
{
	Console.WriteLine(s);
}