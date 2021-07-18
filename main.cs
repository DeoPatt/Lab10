using System;

class MainClass {
  public static void Main (string[] args) {
    
  Employee unknown = new Employee();
  unknown.Intro();
   Employee Robert = new Employee("Robert", "Downey", "12321", 12,1000);
   
   Robert.Intro();
  
  Employee John = new Employee("John", "Smith", "S0089",38,50000);
  John.Intro();
  John.IncreaseSalary(-2);
  John.RemoveEmployee();
  
  Employee Maria = new Employee("Maria", "Lambert", "S0100", 26,80000);
  Maria.Intro();
  Maria.IncreaseSalary(7);
  Maria.RemoveEmployee();
  Maria.RemoveEmployee();
  }
}