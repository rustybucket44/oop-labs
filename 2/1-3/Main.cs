using System;
using System.Collections.Generic;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	int[] arr = arrayMaker.CreateArray1D(8, true);
        	List<int> arr2 = new List<int>();
        	arr2.Add(arr[0]);
        	arrayMaker.PrintArray1D(arr);
            for (int check = 1; check <=3; check++){
            	for (int i=1; i<arr.Length; i++) {
                    switch(check){
                        //добавляем в список нечетные элементы
            	        case 1:
            	            if (i % 2 != 0){
            	                arr2.Add(arr[i]);
            	            }
                            break;
                        //добавляем в список четные элементы
            	        case 2:
            	            if (i % 2 == 0){
            	                arr2.Add(arr[i]);
            	            }
            	            break;
            	        //заменяем элементы массива элементами списка
                        case 3:
                            arr[i] = arr2[i];
                            break;
            	    }
            	}
            }
            arrayMaker.PrintArray1D(arr);
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler