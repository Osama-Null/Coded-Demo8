using System.Reflection;
using System.Xml.Linq;
using ConsoleApp8.Models;
//       obj
Employee employee = new Employee();

employee.Name = "John Doe";
employee.Email = "ex@gmail.com";

Console.WriteLine($"Name: {employee.Name} | Email: {employee.Email}");

//___________________________________________________________________________________________
string Name, Email, Gender;

Console.Write($"\nEnter your name: ");
Name = Console.ReadLine().Trim();

Console.Write($"Enter your email: ");
Email = Console.ReadLine().Trim();

Console.Write($"Your gender [M/f]: ");
Gender = Console.ReadLine();

Console.WriteLine(employee.Check(Name, Email, Gender));
Console.WriteLine("\n" + employee.Check("Aboudy\t", "Herz\t", "AboudyHerz@gmail.ch\t", "Male\n"));

//___________________________________________________________________________________________
