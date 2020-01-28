using System;
using andereMap;

public class Class2 : Class1
{
    public int namespaceVar = 123456789;

    public void Test()
    {
    class1X += 3;
        Console.WriteLine(class1X);
    }

    protected void Test1()
    {
        Console.WriteLine(class1Y += 9);
    }

    private void Test2()
    {
        //Console.WriteLine(class1Z += 7);
    }

    public static void Test3()
    {
        Console.WriteLine("STATIC FUNCTION");
    }

    public void temp()
    {
        int test123 = 666;
        Console.WriteLine("Variable in een functie: " + test123);
    }
}
