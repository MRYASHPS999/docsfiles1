using System;


class ClassB:ClassA
{
    public override void display()
    {
        base.display();
        Console.WriteLine("This is Child class");
    }
}