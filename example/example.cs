using System;
using DllCallerLib;

namespace Example{
    class Example{
        public static void Main(){
            int result1 = DllCaller.CallFunction<int>("example.dll", "getSum", new Argument[]{
                new Argument("System.Int32", 20),
                new Argument("System.Int32", 30)
            });
            Console.WriteLine(result1);

            int result2 = DllCaller.CallFunction<int>("example.dll", "getSum", new Argument[]{
                new Argument("System.Int32", 10),
                new Argument("System.Int32", 15)
            });
            Console.WriteLine(result2);
        }
    }
}