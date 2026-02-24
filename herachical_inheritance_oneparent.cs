using System;
class demo
{
	static void Main()
	{
		abc a=new abc();
		a.showpar();
		a.showabc();
		
		pqr p=new pqr();
		p.showpar();
		p.showpqr();
		
		xyz x=new xyz();
		x.showpar();
		x.showxyz();
	}
}
class par
{
	public void showpar()
	{
		Console.WriteLine("this is parent class");
	}
}
class abc : par
{
	public void showabc()
	{
		Console.WriteLine("this is abc class");
	}
}
class pqr : par
{
	public void showpqr()
	{
		Console.WriteLine("this is pqr class");
	}
}
class xyz : par
{
	public void showxyz()
	{
		Console.WriteLine("this is xyz class");
	}
}
