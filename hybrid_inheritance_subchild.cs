using System;
class demo
{
    static void Main()
    {
        subchild s=new subchild();
        s.showpar();     
        s.showpqr();     
		s.Showsubchild();
    }
}

class par
{
    public void showpar()
    {
        Console.WriteLine("This is parent class");
    }
}

class abc : par
{
    public void showabc()
    {
        Console.WriteLine("This is abc class");
    }
}

class pqr : par
{
    public void showpqr()
    {
        Console.WriteLine("This is pqr class");
    }
}

class xyz : par
{
    public void showxyz()
    {
        Console.WriteLine("This is xyz class");
    }
}

class subchild : pqr
{
    public void Showsubchild()
    {
        Console.WriteLine("This is subchild Class");
    }
}