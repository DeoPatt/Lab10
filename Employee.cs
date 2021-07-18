 using System;

 class Employee{

private string firstName ;
private string lastName;
private string id;
private int age;
private string adress;
private string phoneNumber;
private string title;
private double yearlySalary;
private string employmentStatus;

public string FirstName{get;set;}
public string LastName{get;set;}
public int Age{
  get{ return age;}
  set{
    if (value<18){
      age = 18;
    Console.WriteLine("age cannot be less than 18 . Age is now set to 18");
    }
    else {
      age = value;
    }

  }

}
public double YearlySalary{
  get{return yearlySalary;}
  set{
    if(value<1000){
      yearlySalary = 1000;
      Console.WriteLine("salary cannot be less than a 1000");
      
    }
    else{
      value = yearlySalary;
    }
  }
}
public string Id{get;set;}
public string EmploymentStatus{get;set;}
public Employee(){

  firstName="unknown";
  lastName="unknown";
  id = "unknown";
  age = 0;
  employmentStatus = "active";
 
}
public Employee(string empfirstName,string emplastName, string empid, int empage, int empyearlySalary)
{
  firstName = empfirstName;
  lastName = emplastName;
  id = empid;
  age = empage;
  employmentStatus = "active";
yearlySalary = empyearlySalary;
}
public void Intro(){
  Console.WriteLine("employee firstname is " +firstName);
  Console.WriteLine("employee lastname is " + lastName);
  Console.WriteLine("employee id is " + id);
  Console.WriteLine("employee age is " + age);
  Console.WriteLine("employee status is currently " + employmentStatus);
 Console.WriteLine("employees yearly salary is " + yearlySalary);
}
public void IncreaseSalary(int percent){
yearlySalary = yearlySalary * percent;
Console.WriteLine("employees updated yearly salary is " + yearlySalary);
  
}
 }