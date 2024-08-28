using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Quotient is " + c);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide By Zero Not Allowed");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Value should be an Integer");
            }
            //catch (Exception ex)
            //{
               
            //    Console.WriteLine("An unexpected error occurred: " + ex.Message);
            //}
            finally
            {
                Console.WriteLine("Finished");
            }
            Console.ReadKey();
        }
    }
}
