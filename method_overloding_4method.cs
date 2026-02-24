using System;
class demo
{
    static void Main()
	{
		pqr p=new pqr();;
		p.method(10);
		p.method('A');
		p.method(43.4f);
		p.method(54.54);
		Console.ReadLine();
	}
}
public class abc
{
	public void method(int a)
	{
		Console.WriteLine("integer value"+a);
	}
	public void method(char c)
	{
		Console.WriteLine("Character value"+c);
	}
	public void method(float f)
	{
		Console.WriteLine("Character value"+f);
	}
	public void method(double d)
	{
		Console.WriteLine("Character value"+d);
	}
}	
public class pqr : abc
{
}