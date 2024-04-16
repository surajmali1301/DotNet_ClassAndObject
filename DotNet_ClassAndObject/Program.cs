using DotNet_ClassAndObject;
using DotNet_ClassAndObject.Abstraction;
using DotNet_ClassAndObject.Static;
using System.Drawing;

//main method is declared by default by the program

Employee emp = new Employee();
emp.Assign();
emp.Accept(1, "Anuj", 20000, 2000, 1000);
emp.CalculateSalary();
String displayEmployee = emp.Display();
Console.Write(displayEmployee);
Console.WriteLine("\n----------------------");

//Student Object
Student stud = new Student();//no parameter

String displayStudent=stud.Display();//Paramterized Constructor
Console.Write(displayStudent);
Console.WriteLine("\n----------------------");
//create Date class with day,month,year members
//Use no parameter & paramterized constructor
//Create object & display data

Date d = new Date();
String displayDate = d.Display();
Console.Write(displayDate);
Console.WriteLine("\n----------------------");
Product p = new Product();
p.PId = 10;
p.Name = "Monitor";
p.Price = 30000.0;

Console.Write($"{p.PId}, {p.Name}, {p.Price}");
Console.WriteLine("\n----------------------");
Book b = new Book();
b.Bid = 10;
b.BName = "Harry Potter";
b.Author = "J.k Rowling";

Console.Write($"{b.Bid}, {b.BName}, {b.Author}");
Console.WriteLine("\n--------------------------");

StaticKeyword_Use sk = new StaticKeyword_Use();

//Console.Write($"{sk.Id} , {sk.Name}");
StaticKeyword_Use sk2 = new StaticKeyword_Use("Anuj");
Console.WriteLine("\n--------------------------");
//Console.Write($"{sk2.Id} , {sk2.Name}");
Console.WriteLine(sk.Display());
Console.Write(sk2.Display());

Console.WriteLine("\n--------------Inheritance Code Output--------------------");
Employee emp3 = new Employee();
emp3.CalculateSalary();
string display = emp.Display();
Console.WriteLine(display);

Manager man = new Manager(1,"Suraj",50000,5000,1000,1000);
man.CalculateSalary();
string display2 = man.Display();
Console.WriteLine(display2);

Employee emp0 = new Manager(3,"Hrishi",40000,5000,3000,1000);
emp0.CalculateSalary();/*at Compile-time it will show is calling to method of Base class(Employee) but at run-time
                        it will call and execute derived class(Manager) method*/
Console.Write(emp0.Display());
Console.WriteLine("\n--------------Abstraction Code Output--------------------");
Circle cs = new Circle();
cs.CalculateArea();
cs.Display();

RectangleShape rt = new RectangleShape();
rt.CalculateArea();
rt.Display();