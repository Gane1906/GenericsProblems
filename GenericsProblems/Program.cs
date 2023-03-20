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
            Console.Write("Enter first float value: ");
            double input4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second float value: ");
            double input5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third float value: ");
            double input6 = Convert.ToDouble(Console.ReadLine());
            demo.FindFloatMax(input4 ,input5 ,input6);
            Console.Write("Enter first String: ");
            String input7 = Console.ReadLine();
            Console.Write("Enter Second String: ");
            String input8 = Console.ReadLine();
            Console.Write("Enter third String: ");
            String input9 = Console.ReadLine();
            demo.FindStringMax(input7, input8, input9);
            GenericDemo genericDemo = new GenericDemo();
            genericDemo.FindMax<int>(input1, input2, input3);
            genericDemo.FindMax<double>(input4, input5, input6);
            genericDemo.FindMax<String>(input7, input8, input9);
        }
    }
}