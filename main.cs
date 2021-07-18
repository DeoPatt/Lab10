using System;

class MainClass {
  public static void Main (string[] args) {
    

    Employee unknown = new Employee();
    unknown.Intro();
    Console.WriteLine("new employee is created");
   Employee John = new Employee("john", "smith", "1234", 45,50000);
    John.Intro();
   John.IncreaseSalary(3);
  

  }
}