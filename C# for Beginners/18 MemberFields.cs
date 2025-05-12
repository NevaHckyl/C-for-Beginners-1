Console.WriteLine("hello opp");

var p = new Person(){
    firstname = "Scott",
    lastname = "Hanselman",
    birthday = new DateOnly(1970,1,1)};
    
public class Person
{
    public string firstname;
    
    public string lastname;
    
    public DateTime birthday;
    
}