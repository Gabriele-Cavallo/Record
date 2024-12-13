// Person person1;
// person1 = new Person("Peter", "Smith", 45);

// var person2 = new Person2("Peter", "Smith", 45);

// var recPerson1 = new Person("Peter", "Smith", 45);
// var recPerson2 = new Person("Peter", "Smith", 45);
// var recPerson3 = recPerson2;
// Console.WriteLine(recPerson1.Equals(recPerson2));
// Console.WriteLine(object.ReferenceEquals(recPerson1, recPerson2));
// Console.WriteLine(object.ReferenceEquals(recPerson2, recPerson3));
// Console.WriteLine("-----------------------------------");
// var classPerson1 = new Person2("Peter", "Smith", 45);
// var classPerson2 = new Person2("Peter", "Smith", 45);
// var classPerson3 = classPerson2;
// Console.WriteLine(classPerson1.Equals(classPerson2));
// Console.WriteLine(object.ReferenceEquals(classPerson1, classPerson2));
// Console.WriteLine(object.ReferenceEquals(classPerson2, classPerson3));

var teacher = new Teacher("J. Washington", "Eighth", "John", "Doe", 45);
teacher.Print();


// Destrutturazione
var recPerson1 = new Person("Peter", "Smith", 45);
var (name, lastName, age) = recPerson1;
Console.WriteLine($"{name}, {lastName}, {age}");

var classPerson1 = new ClassPerson
{
    Name = "Peter",
    LastName = "Smith",
    Age = 45
};
var (name1, lastName1, age1) = classPerson1;
Console.WriteLine($"{name1}, {lastName1}, {age1}");



