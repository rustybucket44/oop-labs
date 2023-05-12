using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
            int[][] arr = arrayMaker.CreateArray2D(6, 4, true);
            arrayMaker.PrintArray2D(arr);
            int width = arr[0].Length;
            int height = arr.Length;
            for (int i=0; i<width; i++) {
                if (i % 2 == 0){
                    int temp;
                    for (int j = 0; j < height; j++){
                        for (int a = j+1; a < height; a++){
                            if (arr[j][i] < arr[a][i]){
                                temp = arr[j][i];
                                arr[j][i] = arr[a][i];
                                arr[a][i] = temp;
                            }
                        }
                    }
                }
            }
            arrayMaker.PrintArray2D(arr);
        }
    }
}