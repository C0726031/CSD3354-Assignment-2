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
            DelegateExercises The = new DelegateExercises();
            The.Method2(50);
        }
    }
    public class DelegateExercises
    {
        public delegate void MyDelegate(int i);
        public void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public void Method2(int i)
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(50);
        }
    }
}
