using System;

class Program

{
    static void Main(string[]args)
    {

        Employee.display(); //calling static method

        Employee emp = new Employee(); //object creation

        emp.display2(); //non static method calling

        string name1 = emp.disName("Jayesh");
        Console.WriteLine(name1);


        double dbl1 = emp.Addval(34, 567);
        Console.WriteLine(dbl1);

        //int id;
        //string name;
        //double salary;

        //Console.WriteLine("Enter Name:");
        //name=Console.ReadLine();

        //Console.WriteLine("Enter Id:");
        //id = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter Salary:");
        //salary = double.Parse(Console.ReadLine());

        //string empdet = $"ID is {id}, Name is {name}, Salary is {salary}";
        //Console.WriteLine(empdet);

    }
}
