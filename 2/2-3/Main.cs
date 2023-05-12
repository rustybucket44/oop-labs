using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[][] arr = arrayMaker.CreateArray2D(6, 4, true);
            arrayMaker.PrintArray2D(arr);
            int width = arr[0].Length;
            int height = arr.Length;
            for (int i=0; i<height; i++) {
                int j = 0;
                int sum = 0;
                bool shouldSum = false;
                while (j < width){
                    if (shouldSum) {
                        sum = sum + arr[i][j];
                        j++;
                    }else{
                        if (arr[i][j] < 0) {
                            shouldSum = true;
                            j = 0;
                        }else{
                            j++;
                        }
                    }
                }
                if (shouldSum) {
                    Console.WriteLine($"Row #{i} Sum: {sum};");
                }
            }
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler