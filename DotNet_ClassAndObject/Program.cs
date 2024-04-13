using DotNet_ClassAndObject;

//main method is declared by default by the program

Employee emp = new Employee();
emp.Assign();
emp.Accept(1, "Anuj", 20000, 2000, 1000);
emp.CalculateSalary();
String displayEmployee = emp.display();
Console.Write(displayEmployee);


//Student Object
Student stud = new Student();//no parameter

String displayStudent=stud.Display();//Paramterized Constructor
Console.Write(displayStudent);

//create Date class with day,month,year members
//Use no parameter & paramterized constructor
//Create object & display data

Date d = new Date();
String displayDate = d.Display();
Console.Write(displayDate);

Product p = new Product();
p.PId = 10;
p.Name = "Monitor";
p.Price = 30000.0;

Console.Write($"{p.PId}, {p.Name}, {p.Price}");

Book b = new Book();
b.Bid = 10;
b.BName = "Harry Potter";
b.Author = "J.k Rowling";

Console.Write($"{b.Bid}, {b.BName}, {b.Author}");