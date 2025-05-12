Console.WriteLine("hello opp");

var p1 = new Person("Scott", "Henselman",new DateOnly(1970,1,1));
var p2 = new Person("David", "Fowler",new DateOnly(1986,1,1));

List<Person> people =[p1,p2];

Console.WriteLine(people.Count);
    
public class Person (string firstname, string lastname, DateOnly birthday)
{
    public string first {get; } = firstname;
    
    public int Last {get; } = lastname;
    
    public int Birthday {get; } = birthday;
}
