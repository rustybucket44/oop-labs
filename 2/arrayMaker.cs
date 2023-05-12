using System;

namespace MainNamespace{
    class arrayMaker{
        
        // create 1-dimensional arrays
        public static int[] CreateArray1D(int _length, bool _random){
            var rand = new Random();
            
            int length = _length;
            if (length == -1){
                Console.WriteLine("Input Array length: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            }
            int[] arr = new int[length];
            
            for (int i=0; i<length; i++) {
                if (_random){
                    arr[i] = rand.Next(-20, 20);
                }else{
                    Console.WriteLine($"Input Element #{i.ToString()}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        
        // create 2-dimensional arrays
        public static int[][] CreateArray2D(int _width, int _height, bool _random){
            var rand = new Random();
            
            int height = _height;
            if (height == -1){
                Console.WriteLine("Input Array Length: ");
                height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            }
            int width = _width;
            if (width == -1){
                Console.WriteLine("Input Array Width: ");
                width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
            }
            
            int[][] arr = new int[height][];
            for (int i=0; i<height; i++) {
                arr[i] = new int[width];
            }
            
            for (int i=0; i<height; i++) {
                for (int j=0; j<width; j++) {
                    if (_random){
                        arr[i][j] = rand.Next(-20, 20);
                    }else{
                        Console.WriteLine($"Input Element #({i.ToString()}, {j.ToString()}): ");
                        arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return arr;
        }
        
        // print 1-dimensional array
        public static void PrintArray1D(int[] _arr){
            Console.WriteLine($"\n\nArray Output: ");
            for (int i=0; i<_arr.Length; i++) {
                Console.Write($"{_arr[i].ToString()}");
                if (i != _arr.Length-1){
                    Console.Write(", ");
                }
            }
        }    
        
        // print 2-dimensional array
        public static void PrintArray2D(int[][] _arr){
            Console.WriteLine($"\n\nArray Output: ");
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
    }
}