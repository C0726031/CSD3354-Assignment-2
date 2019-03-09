using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents


{ 
    class Program
{
    static void Main(string[] args)
    {
        DelegateExercises de = new DelegateExercises();
        de.Method2();
    }
}
public class DelegateExercises
{
    public delegate void MyDelegate();

        
        public void Method1()
    {
        Console.WriteLine("Method1");
        Console.ReadLine();
    }
    public void Method2()
    {
        MyDelegate myDelegate = new MyDelegate(Method2);
        myDelegate();

    }
         
}
}