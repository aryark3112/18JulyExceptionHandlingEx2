using System;
using System.CodeDom;

namespace _18July
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exception Hnadling
            int num1, num2, result;
            try
            {
                Console.WriteLine("Enter First Number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("Result after adding {0} and {1} = \t {2}", num1, num2, result);
            }
            catch (Exception ex)
                {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            finally{
                Console.WriteLine("End of Program!!!");
                Console.ReadKey();
            }
            
        }
    }
}
