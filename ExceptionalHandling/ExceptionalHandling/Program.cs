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
                int[] populatedArray = Populate(valueArray);
                // To capture sum of array
                GetSum(valueArray);
                // To capture product of array
                GetProduct(valueArray);
                // To capture quotient of array
                GetQuotient(userArrvalueArrayay);
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

        static int[] Populate(int[] numArray)
        {
            string userResponse;
            for (int i = 0; i < numArray.Length; i++)
            {
                 Console.WriteLine("Please enter numerical value!");
                 userResponse = Console.ReadLine();
                 numArray[i] = Convert.ToInt32(userResponse);
            }

            return numArray;

        }
    }
}
