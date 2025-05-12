List<int> scores ={ 3, 45, 82, 97, 100, 81, 60};

IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending 
    select $"The score is {score}";

Console.WriteLine(scoreQuery.Count());

foreach (string s in scoreQuery)
{
    Console.writeLine(s);
}