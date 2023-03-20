using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class Demo
    {
        public void FindIntMax(int a,int b,int c)
        {
            if (a > b && a > c)
                Console.WriteLine(a + " is maximum");
            if (b > a && b > c)
                Console.WriteLine(b + " is maximum");
            else
                Console.WriteLine(c + " is maximum");
        }
    }
}
