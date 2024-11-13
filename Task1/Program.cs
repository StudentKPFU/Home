using System;

namespace Home
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("***********");
            Console.WriteLine(" ||||||||| ");
            Console.WriteLine(" ||||||||| ");
            Console.WriteLine("***********");
            */
            Console.WriteLine(CalculateOp(5, 4, '-'));
        }
        



        static double CalculateOp(long a, long b, char operand)
        {
            switch(operand)
            {
                case '+': return a + b;

                case '-': return a - b;

                case '*': return a * b;

                case '/': return (double)a / b;

                case '^': return Math.Pow(a, b);

                default: return default(double);
            }
        }
    }


    
}