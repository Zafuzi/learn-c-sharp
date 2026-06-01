List<int> scores = [3, 45, 82, 97, 92, 100, 81, 60];

IEnumerable<string> scoreQuery =
	from score in scores
	where score > 80
	orderby score descending
	select $"Found score: {score}";

/*
var scoreQuery = scores
	.Where(score => score > 80)
	.OrderByDescending(s => s);
*/

List<string> myScores = scoreQuery.ToList();

foreach (var s in myScores)
{
	Console.WriteLine(s);
}