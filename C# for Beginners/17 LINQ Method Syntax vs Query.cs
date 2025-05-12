List<int> scores ={ 3, 45, 82, 97, 100, 81, 60};

IEnumerable<int> scoreQuery =
   from score in scores
  where score > 80
   orderby score descending 
   select score;

var scoreQuery2 = scores.Where(s=> s>80).
           OrderByDescending(s=> s);

List<int> myScore = scoreQuery.ToList();

foreach (var score in myScores)
{
    Console.writeLine(s);
}