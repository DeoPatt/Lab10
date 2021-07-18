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
private bool status;
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
  employmentStatus = "Unknown";
  status = true;
 
}
public Employee(string empfirstName,string emplastName, string empid, int empage, int empyearlySalary)
{
  firstName = empfirstName;
  lastName = emplastName;
  id = empid;
  age = empage;
  employmentStatus = "active";
  status = true;
yearlySalary = empyearlySalary;
}
public void Intro(){
  Console.WriteLine(" firstname: " +firstName);
  Console.WriteLine("lastname: " + lastName);
  Console.WriteLine(" id: " + id);
  Console.WriteLine(" age: " + age);
  Console.WriteLine("employee status: " + employmentStatus);
 Console.WriteLine("employees yearly salary: " + yearlySalary);
}
public void IncreaseSalary(double percent){
  percent = percent / 100 ;
  
 double bonus = percent * yearlySalary;
  double Total = yearlySalary + bonus;
  if (percent<0)
  {
    Console.WriteLine("Invalid input. Yearly salary not updated");
    return;
  }
Console.WriteLine("employee salary updated " + Total);

}
public void RemoveEmployee(){
  
  if (status == false)
  {
    Console.WriteLine("Employee already inactive");
  }
  if (status == true)
  {
    status = false;
    Console.WriteLine("Employee removed Sucessfully !");
  }
}
 }