using System;

namespace ExceptionalHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSeuence();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Your Error was {e.Message}");
            }
            finally
            {
                Console.WriteLine("Your application is finish!");
            }
        }

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Enter a value that is greater than zero(0)");
                int userValue = Convert.ToInt32(Console.ReadLine());
                int[] valueArray = new int[userValue];
                // To populate
                Populate(userArray);
                // To capture sum of array
                GetSum(userArray);
                // To capture product of array
                GetProduct(userArray);
                // To capture quotient of array
                GetQuotient(userArray);
            }
            catch (FormatException e)
            {
                Console.WriteLine("You had formatting error");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("You had overflow error please put exact value for its type");
            }
           
        }

    }
}
