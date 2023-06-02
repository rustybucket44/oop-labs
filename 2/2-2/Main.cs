using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[][] arr = arrayMaker.CreateArray2D(8, 8, true);
            arrayMaker.PrintArray2D(arr);
            bool happened = false;
            for (int i=0; i<7; i++) {
                for (int j=0; j<7; j++) {
                    int happened2 = 0;
                    for (int a=0; a<7; a++) {
                        if (arr[i][a]==arr[a][j]){
                            happened2 += 1;
                        }
                    }
                    if (happened2 == 8){
                        Console.WriteLine($"Row #{j} match with Column #{i}!");
                        happened = true;
                    }
                }
            }
            if (happened == false){
                Console.WriteLine("\nNo matches found :(");
            }
        }
    }
}