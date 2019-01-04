using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace monkeyCode
{
	class Program
	{
	    struct Film
	    {
	        public string title;
	        public double price;
	        public string star;
	    }
		static void Main(string[] args)
		{
		    Film f;
		    f.title = "Man on Fire";
		    f.price = 4.99;
		    f.star = "Denzel Washington";
		    
		    Film f2;
		    f2.title = "Aquaman";
		    f2.price = 14.99;
		    f2.star = "Jason Momoa";
		    
		    Console.WriteLine("You know that " + f.title + " is my favorite movie!");
		
		}
	}
}
