using System;
namespace GenericsProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Demo demo=new Demo();
            Console.Write("Enter first integer value: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first integer value: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter first integer value: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            demo.FindIntMax(input1,input2,input3);
        }
    }
}