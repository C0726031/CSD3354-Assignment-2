using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Harpreet Kaur(C0726031)
//Simranjeet Kaur(C0727100)

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises the = new DelegateExercises();
            the.Method3(10);
            Console.Read();
        }

    }

    public class DelegateExercises
    {
        public delegate int MyDelegate(int i);
        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3(int intMethod3)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}