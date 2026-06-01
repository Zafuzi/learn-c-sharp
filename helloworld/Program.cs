string firstName = "Noah";
string secondName = "Sbonga";
string friends = $"My friends are {firstName.Trim()} and {secondName.Trim()}.";
string otherFriend = friends.Replace("Noah", "Joe"); 

Console.WriteLine(friends);
Console.WriteLine(friends.Length);
Console.WriteLine(otherFriend.Contains(firstName));