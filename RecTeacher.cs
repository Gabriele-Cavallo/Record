record Teacher(string School, string Grade, string Name, string LastName, int Age):
 Person(Name, LastName, Age)
 {
   public new void Print(){
        base.Print();
        Console.WriteLine($"{School}, {Grade}");
    }
} 