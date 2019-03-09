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
        public static void Main(string[] args)
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
            return intMethod1 * 4;
        }
        public int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
        public void Method3(int intMethod3)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}