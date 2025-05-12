var names = new string [] {"Scott","Ana","Felipe"};

names= [..name,"Damian"];

foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()!}");
}