using System; 

class joe { 
	static int josephus(int n) 
	{ 
		
		int pos = 0;
    for (int i = 1; i <= n; i++)
      pos = (pos + 2) % i;
    return pos+1 ;
	} 
	static void Main() 
	{  
		Console.Write("Enter the no ");
		int n= int.Parse(Console.ReadLine());
		Console.Write("The safe place is " + josephus(n)); 
	} 
} 