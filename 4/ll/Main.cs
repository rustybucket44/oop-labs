using System;
using System.Collections.Generic;

namespace MainNamespace{
    class MainClass{
        //zovnishnii dobutok
        public static LinkedList<LinkedList<int>> OutMul(LinkedList<int> vec1, LinkedList<int> vec2){
            LinkedList<LinkedList<int>> res = new LinkedList<LinkedList<int>>();
            foreach (int val1 in vec1){
                LinkedList<int> row = new LinkedList<int>();
                foreach (int val2 in vec2){
                    row.AddLast(val1 * val2);
                }
                res.AddLast(row);
            }
            return res;
        }

        //output
        public static void PrintLinkedList2D(LinkedList<LinkedList<int>> arr){
            foreach (LinkedList<int> row in arr){
                if (row != arr.First.Value){
                    Console.WriteLine();
                }
                foreach (int val in row){
                    Console.Write($"{val.ToString()}".PadLeft(4));
                    if (val != row.Last.Value){
                        Console.Write(", ");
                    }
                }
            }
        }

        //main
        static void Main(string[] args){
            LinkedList<int> vec1 = new LinkedList<int>(new int[] { 1, 2, 3 });
            LinkedList<int> vec2 = new LinkedList<int>(new int[] { 4, 5, 6 });
            LinkedList<LinkedList<int>> result = OutMul(vec1, vec2);
            PrintLinkedList2D(result);
        }
    }
}
