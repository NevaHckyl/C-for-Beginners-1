Console.WriteLine("Hello, David!");

string firstFriend = "Maria";
firstFriend = firstFriend.Trim();

string secondFriend = "Scott";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";
Console.WriteLine(friends);

friends = friends.Replace("Scott", "Damian");
Console.WriteLine(friends);
