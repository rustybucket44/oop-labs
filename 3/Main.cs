using System;
namespace MainNamespace{
    class MainClass{
        static void Main(string[] args) {
        	IPercentNum numba = new PercentNum(200.0);
    		Console.WriteLine($"numba: {numba.Value}; ");
    		Console.WriteLine($"numba 50% (just show): {numba.getPercent(50)}; ");
    		numba.incPercent(25);
    		Console.WriteLine($"numba after +25%: {numba.Value}; ");
    		numba.decPercent(50);
    		Console.WriteLine($"numba after -50%: {numba.Value}; ");
        }
    }
}
//https://www.onlinegdb.com/online_csharp_compiler