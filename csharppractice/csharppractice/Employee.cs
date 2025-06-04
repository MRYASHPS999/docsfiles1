using System;

class Employee
{
    public static void display()
    {
        Console.WriteLine("This is static Method");
    }

    public void display2()
    {
        Console.WriteLine("This is Non-Static Method");
    }

    public string disName(string name)
    {
        return name;
    }

    public double Addval(int a, int b)
    {
        double c = a + b;
        return c;
    }


}