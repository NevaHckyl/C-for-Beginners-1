Console.WriteLine ("hello oop");

var p1= new Person("Scott","Kanselman",new DateOnly(1970,1,1));
var p2= new Person("David","Fowler"new DateOnly(1986,1,1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));
p2.Pets.Add(new Cat("Beyonce"));

List<Person> people =[p1,p2];

foreach(var person in people)
{       
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
       Console.WriteLine($"    {pet}");
    }
}

Console.WriteLine("people.Count");

public class Person(string firstname, string lastname,DateOnly birthday)
{
    public sting First {get;} = firstname;
    public string Last {get;} = lastname;
    public DateOnly Birthday {get;} = birthday;

    public List<Pet> Pets {get;}= new();
    
    public override string ToString()
    {
        return $"Human{Fiirst} {Last}";
    }
}

 public abstract class Pet(string firstname)
{
public sting First {get;} = firstname;
public abstract string MakeNoise();
public override string ToString()
    {
        return $"{First} and I am a{GetType().Name}and I{MakeNoise()}";
    }
}

public class Cat (string firstname): Pet(firstname)
{
    public override string MakeNoise() => "meow";

}

public class Dog (string firstname): Pet (firstname)
{
   public override string MakeNoise() => "bark";
}