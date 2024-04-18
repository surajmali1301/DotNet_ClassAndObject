//using DotNet_ClassAndObject;
//using DotNet_ClassAndObject.Abstraction;
//using DotNet_ClassAndObject.Array;
//using DotNet_ClassAndObject.Interface;
//using DotNet_ClassAndObject.Partial_Class;
//using DotNet_ClassAndObject.Static;
//using System.Drawing;

////main method is declared by default by the program

//Employee emp = new Employee();
//emp.Assign();
//emp.Accept(1, "Anuj", 20000, 2000, 1000);
//emp.CalculateSalary();
//String displayEmployee = emp.Display();
//Console.Write(displayEmployee);
//Console.WriteLine("\n----------------------");

////Student Object
//Student stud = new Student();//no parameter

//String displayStudent = stud.Display();//Paramterized Constructor
//Console.Write(displayStudent);
//Console.WriteLine("\n----------------------");
////create Date class with day,month,year members
////Use no parameter & paramterized constructor
////Create object & display data

//Date d = new Date();
//String displayDate = d.Display();
//Console.Write(displayDate);
//Console.WriteLine("\n----------------------");
//Product p = new Product();
//p.PId = 10;
//p.Name = "Monitor";
//p.Price = 30000.0;

//Console.Write($"{p.PId}, {p.Name}, {p.Price}");
//Console.WriteLine("\n----------------------");
//Book b = new Book();
//b.Bid = 10;
//b.BName = "Harry Potter";
//b.Author = "J.k Rowling";

//Console.Write($"{b.Bid}, {b.BName}, {b.Author}");
//Console.WriteLine("\n--------------------------");

//StaticKeyword_Use sk = new StaticKeyword_Use();

////Console.Write($"{sk.Id} , {sk.Name}");
//StaticKeyword_Use sk2 = new StaticKeyword_Use("Anuj");
//Console.WriteLine("\n--------------------------");
////Console.Write($"{sk2.Id} , {sk2.Name}");
//Console.WriteLine(sk.Display());
//Console.Write(sk2.Display());

//Console.WriteLine("\n--------------Inheritance Code Output--------------------");
//Employee emp3 = new Employee();
//emp3.CalculateSalary();
//string display = emp.Display();
//Console.WriteLine(display);

//Manager man = new Manager(1, "Suraj", 50000, 5000, 1000, 1000);
//man.CalculateSalary();
//string display2 = man.Display();
//Console.WriteLine(display2);

//Employee emp0 = new Manager(3, "Hrishi", 40000, 5000, 3000, 1000);
//emp0.CalculateSalary();/*at Compile-time it will show is calling to method of Base class(Employee) but at run-time
//                        it will call and execute derived class(Manager) method*/
//Console.Write(emp0.Display());
//Console.WriteLine("\n--------------Abstraction Code Output--------------------");
//Circle cs = new Circle();
//cs.CalculateArea();
//cs.Display();

//RectangleShape rt = new RectangleShape();
//rt.CalculateArea();
//rt.Display();
//Console.WriteLine("\n--------------Interface Code Output--------------------");
//Job j = new Job();
//double tax = j.Tax();
//Console.WriteLine("Tax of Job: " + tax);

//Business b1 = new Business();
//double taxB = b1.Tax();
//Console.Write("Tax of Business: " + taxB);
//Console.WriteLine("\n--------------Interface Explicit Code Output--------------------");
//ICustomer ic = new Transactiion();
//Console.WriteLine(ic.print());

//ICustomerOrder io = new Transactiion();
//Console.WriteLine(io.print());
//Console.WriteLine("\n--------------Partial Class Code Output--------------------");
//Calc c = new Calc();
//Console.WriteLine(c.Add(10, 20));
//Console.WriteLine(c.Sub(10, 20));

//Console.WriteLine("\n-----------------------------");
//int[] arr = { 1, 2, 3, 4 };
//FrequencyOfElements fs = new FrequencyOfElements();
//fs.GetCount(arr);

//Console.WriteLine("\n-----------------------------");

//int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
////console.write("enter the index to remove element: ");
////int index = Convert.ToInt32(Console.ReadLine());
//int index = 3;
//arr = RemoveElementUsingIndex.RemoveElement(arr1, index);

//Console.WriteLine("Array after remove element at index " + index);
//foreach (int num in arr)
//{
//    Console.Write(num + " ");
//}
//Console.WriteLine("\n-----------------------------");
//Product[] pArr = new Product[1]
//       {
//            new Product{PId=1,Name="Monitor",Price=3000}
//       };
//foreach (Product item in pArr)
//{
//    Console.WriteLine($"{item.PId} - {item.Name} - {item.Price}");
//}
//Console.WriteLine("\n-----------------------------");
//int[] newArr = { 80, 45, 78, 12, 1 };

//Array.Sort(newArr);
//foreach (int num in newArr)
//{
//    Console.WriteLine(num + " ");
//}
//Console.WriteLine("\n-----------Array.Reverse()------------------");
//Array.Reverse(newArr);
//foreach (int num in newArr)
//{
//    Console.WriteLine(num + " ");
//}
//Console.WriteLine("\n------------Array.Copy()-----------------");

//int[] newArr2 = new int[newArr.Length - 2];
//Array.Copy(newArr, 2, newArr2, 0, 3);
//foreach (int num in newArr2)
//{
//    Console.WriteLine(num + " ");
//}
//Console.WriteLine("\n-----------Array.Clear()------------------");
//Array.Clear(newArr, 2, 3);
//foreach (int num in newArr)
//{
//    Console.WriteLine(num + " ");
//}
//Console.WriteLine("\n-----------Array.Sort() String------------------");
//string[] arr5 = { "Suraj", "Anuj", "Hrishikesh", "Somesh" };
//Array.Sort(arr5);
//foreach (string item in arr5)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n-----------Array.Reverse() String------------------");
//string[] arr3 = { "Suraj", "Anuj", "Hrishikesh", "Somesh" };
//Array.Reverse(arr3);
//foreach (string item in arr3)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n-----------Array.Copy() String------------------");
//string[] arr4 = { "Suraj", "Anuj", "Hrishikesh", "Somesh" };
//string[] strings = new string[arr4.Length];
//Array.Copy(arr4, 1, strings, 0, 2);
//foreach (string item in strings)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n-----------Array.Clear() String------------------");
//Array.Clear(arr3, 1, 2);
//foreach (string item in arr3)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine("\n-----------------------------");
//int[,] a = new int[3, 3]
//{
//    {2,2,2 },
//    {2,2,2 },
//    {2,2,2 }
//};

//int[,] a2 = new int[3, 3]
//{
//    {1,1,1 },
//    {1,1,1 },
//    {1,1,1 }
//};

//int[,] result = new int[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j2 = 0; j2 < 3; j2++)
//    {
//        result[i, j2] = a[i, j2] + a2[i, j2];
//        Console.Write($"{result[i, j2]} ");
//    }
//}
