using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
//Harpreet Kaur(C0726031)
//Simranjeet Kaur(C0727100)


{
    class Program
    {
        static void Main(string[] args)
        

            {
                DelegateExercises The = new DelegateExercises();
                The.Method2();
            }

        }
        public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }
    }
