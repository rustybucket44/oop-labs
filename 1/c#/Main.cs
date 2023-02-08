using System;

namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	TCircle ball1 = new TCircle();
        	TCircle ball2 = new TCircle(3);
        	TCircle ball3 = new TCircle(ball2);
        	
        	Console.WriteLine("ball2 area: " + ball2.getArea());
    		Console.WriteLine("ball1 > ball3: " + ball1.isBiggerThan(ball3));
    		ball1.incRad(10);
    		Console.WriteLine("ball1 > ball3: " + ball1.isBiggerThan(ball3));
    		
    		Console.WriteLine("-------------------");
    		
        	TCyllinder cyll1 = new TCyllinder(3, 5);
        	TCyllinder cyll2 = new TCyllinder(cyll1);
        	Console.WriteLine("cyll1 area: " + cyll1.getArea());
        	Console.WriteLine("cyll1 volume: " + cyll1.getVolume());
        	Console.WriteLine("cyll2 volume: " + cyll2.getVolume());
        	cyll2.mulRad(2);
        	Console.WriteLine("cyll2 volume: " + cyll2.getVolume());
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler