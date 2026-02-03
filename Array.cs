using System;
class demo
{
	static void Main(string[] args)
	{
		Console.WriteLine("enter size for array");
		int size=Convert.ToInt32(Console.ReadLine());
		
			int[]a=new int[size];
			a[0]=3;
			a[1]=4;
			a[2]=7;
			
				Console.WriteLine("size of array:"+a.Length);
				
				for(int i=0; i<a.Length; i++)
				{
					Console.WriteLine(a[i]);
			    }
					Console.ReadLine();
		}
}
	