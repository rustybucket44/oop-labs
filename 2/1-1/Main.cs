using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[] arr = arrayMaker.CreateArray1D(8, true);
        	bool happened = false;
        	arrayMaker.PrintArray1D(arr);
        	for (int i=0; i<arr.Length-2; i++) {
        	    if (arr.Length < (i+2)) {
        	        break;
        	    }
        	    if (arr[i]-arr[i+1] == arr[i+1] - arr[i+2]){
        	        Console.Write($"Elements #{i}, #{i+1} and #{i+2} form a progression\n");
        	        happened = true;
        	    }
        	}
        	if (happened == false){
        	    Console.Write("No progressions encountered\n");
        	}
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler