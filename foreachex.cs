using System;
class foreachex
{
	static void Main()
	{
		int[] a=new int[5]{3,5,2,7,2};
		foreach(int v in a)
		{
			Console.WriteLine(v);
		}
		Console.WriteLine();
		for(int i=0; i<a.Length; i++)
		{	
				Console.WriteLine(a[i]);
		}
		Console.WriteLine();
		int w=0;
		while(w<a.Length)
		{
			Console.WriteLine(a[w]);
			w++;	
		}
		Console.WriteLine();
		int d=0;
		do
		{
			Console.WriteLine(a[d]);
			d++;
		}
		while(d<a.Length);
	}	
}
		