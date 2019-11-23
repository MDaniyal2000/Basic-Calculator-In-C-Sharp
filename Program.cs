using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int count = 0;
            while (true){
                Console.Write("Enter yes to continue or no to quit:\t");
                string input = Console.ReadLine();
                if (input == "no" || count > 9)
                {
                    break;
                }
                Console.WriteLine("Enter information:");
                Console.Write("1. Enter Operand 1: ");
                int op1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("1. Enter Operand 2: ");
                int op2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("1. Enter Operation: ");
                string op = Console.ReadLine();
                Console.Write("1. Enter Index: ");
                int index = Convert.ToInt32(Console.ReadLine());
                int res = 0;
                switch (op)
                {
                    case "+":
                        res = op1 + op2;
                        break;

                    case "-":
                        res = op1 - op2;
                        break;

                    case "*":
                        res = op1 * op2;
                        break;

                    case "/":
                        res = op1 / op2;
                        break;
                }
                // Store result
                arr[index] = res;
                // Print result
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(i + "th index and result is:\t" + arr[i]);
                }
                count++;
            }
        }
    }
}
