using System;

namespace MainNamespace{
    class MainClass{
        //zovnishnii dobutok
        public static int[][] OutSum(int[] _vec1, int[] _vec2) {
            int[][] res = new int[_vec1.Length][];
            for (int i = 0; i < _vec1.Length; i++) {
                res[i] = new int[_vec2.Length];
                for (int j = 0; j < _vec2.Length; j++) {
                    res[i][j] = _vec1[i] * _vec2[j];
                }
            }
            return res;
        }
        
        //output
        public static void PrintArray2D(int[][] _arr){
            for (int i=0; i<_arr.Length; i++) {
                if (i!=0){
                    Console.Write("\n");
                }
                for (int j=0; j<_arr[i].Length; j++) {
                    Console.Write($"{_arr[i][j].ToString()}".PadLeft(4));
                    if (j != _arr[i].Length-1){
                        Console.Write(", ");
                    }
                }
            }
        }
        
        //main 
        static void Main(string[] args) {
            int[] vec1 = {1, 2, 3};
            int[] vec2 = {4, 5, 6};
            int[][] result = OutSum(vec1, vec2);
            PrintArray2D(result);
        }
    }
}