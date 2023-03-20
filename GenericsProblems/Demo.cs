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
            if (c > a && c > b)
                Console.WriteLine(c + " is maximum");
        }
        public void FindFloatMax(double a ,double  b ,double c )
        {
            if (a > b && a > c)
                Console.WriteLine(a + " is maximum");
            if (b > a && b > c)
                Console.WriteLine(b + " is maximum");
            if (c > a && c > b)
                Console.WriteLine(c + " is maximum");
        }
        public void FindStringMax(string a ,string b ,string c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine(a+" comes first in three strings");
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine(a + " comes first in three strings");
            if (c.CompareTo(b) > 0 && c.CompareTo(a) > 0)
                Console.WriteLine(a + " comes first in three strings");
        }

    }
}
