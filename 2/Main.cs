using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[] aboba2 = arrayMaker.CreateArray1D(5, true);
        	arrayMaker.PrintArray1D(aboba2);
        	int[][] aboba = arrayMaker.CreateArray2D(7, 4, true);
        	arrayMaker.PrintArray2D(aboba);
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler