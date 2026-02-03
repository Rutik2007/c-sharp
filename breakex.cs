using System;
class breakex
{
	static void Main()
	{
		int i=0;
		while(i<10)
		{
			i++;
			if(i==3)
			break;
		}
		Console.WriteLine("loop stooped at i="+i);
	}
}