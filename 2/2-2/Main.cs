using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[][] arr = arrayMaker.CreateArray2D(8, 8, true);
            arrayMaker.PrintArray2D(arr);
            bool happened = false;
            for (int i=0; i<7; i++) {
                for (int j=0; j<7; j++) {
                    if ((arr[i][1]==arr[1][j]) && (arr[i][2]==arr[2][j]) && (arr[i][3]==arr[3][j]) && (arr[i][4]==arr[4][j]) && (arr[i][5]==arr[5][j]) && (arr[i][6]==arr[6][j]) && (arr[i][7]==arr[7][j]) && (arr[i][0]==arr[0][j])){
                        Console.WriteLine($"Row #{j} match with Column #{i}!");
                        happened = true;
                    }
                }
            }
            if (happened == false){
                Console.WriteLine("No matches found :(");
            }
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler