class ClassPerson
{
    public string Name {get; set;} = "";
    public string LastName {get; set;} = "";
    public int Age {get; set;}

    public void Deconstruct(out string name, out string lastName, out int age)
    {
        name = Name;
        lastName = LastName;
        age = Age;
    }
}