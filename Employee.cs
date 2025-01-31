using System;

class Employee{
	
     private string name;
	 private int id;
	 private double salary;
	 
	 
	 public  Employee(string name, int id ,double salary){
	  this.name=name;
	  this.id=id;
	  this.salary=salary;
	  
	 }
	 
	 public void DetailDisplay(){
	 
	 Console.WriteLine("name of employee :" +name);
	 Console.WriteLine("id of employee :" +id);
	 Console.WriteLine("salary of employee :"+salary);
	  
	 }
	 
	 }
	 
	 class EmployeeDetails {
		 
		 public static void Main(string[] args){
		Console.WriteLine("Enter name:");
		string name= Console.ReadLine();
		
		Console.WriteLine("Enter id :");
		int id=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter salary :");
		double salary=Convert.ToDouble(Console.ReadLine());
		
		Employee emp= new Employee(name,id,salary);
		emp. DetailDisplay();
		
	 
	 }


}