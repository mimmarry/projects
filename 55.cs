using System;

class Programm
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int a = rnd.Next();
        int b = rnd.Next();
        int c = rnd.Next();
        Console.WriteLine(a + "  " + b + "  " + c);
        Console.ReadLine();
    }
}
/* eigth number 
 * using System;

class Programm
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int a = rnd.Next();
        int b = rnd.Next();
        int c = rnd.Next();
        int d = rnd.Next();
        Console.WriteLine(a + " " + b + " " + c + " " + d);
        Console.ReadLine();
    }
}
/*using System;

class Programm
{
    static void Main(string[] args)
    {
        int a = 1;
        int b = 12;
        int c = 49;
        Console.WriteLine(a + " " + b + " " + c);
        Console.ReadLine();
    }
}