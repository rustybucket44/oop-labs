using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	Console.WriteLine("First 2 elemnts - X Coords, next 2 - Y coords\n");
        	int[] coords = arrayMaker.CreateArray1D(4, false);
        	if ((coords[0]*coords[1]) + (coords[2]*coords[3]) == 0) {
        	    Console.WriteLine("Yes\n");
        	}else{
        	    Console.WriteLine("No\n");
        	}
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler