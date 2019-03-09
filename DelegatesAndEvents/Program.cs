using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Harpreet Kaur(C0726031)
//Simranjeet Kaur(C0727100)

namespace DelegatesAndEvents
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            DelegateExercises the = new DelegateExercises();
            the.Method3();
            Console.ReadLine();
        }
    }
    delegate int MyDelegate(out int i);
    public class DelegateExercises
    {
        int Method1(out int i)
        {

            i = 100;
            Console.WriteLine("Method 1 " + i);
            return 0;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            MyDelegate myDelegate1 = null;
            MyDelegate myDelegate2 = myDelegate + myDelegate1;
            int intValue;
            myDelegate2(out intValue);
        }


    }

}
