// record Person(string Name, string LastName, int Age);
record class Person(string Name, string LastName, int Age)
{
   public void Print(){
        Console.WriteLine($"{Name}, {LastName}, {Age}");
    }
} 
class Person2(string name, string lastName, int age)
{
    public string Name {get; init;} = name; 
    public string LastName {get; init;} = lastName; 
    public int Age {get; init;} = age; 
    virtual public void Print(){
        Console.WriteLine($"{Name}, {LastName}, {Age}");
    }
} 