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
                int totalValue = GetSum(populatedArray);
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
            // storing input from user
            string userResponse;
            // Running the for loop to save each response depending on the length of an array
            for (int i = 0; i < numArray.Length; i++)
            {
                 Console.WriteLine("Please enter numerical value!");
                 userResponse = Console.ReadLine();
                 numArray[i] = Convert.ToInt32(userResponse);
            }
            // Returning the value
            return numArray;
        }

        static int GetSum(int[] numArray)
        {
            // Creating new variable to store sum of number from Populated array
            int sum = 0;
            // ForEach loop is adding all the values to the sum
            foreach (int values in numArray)
            {
                sum += values;
            }
            // Logic is checking if sum is less than 20 than will throw error
            if (sum < 20)
                throw new Exception("Value of {sum} is too low");

            return sum;
        }


    }
}
