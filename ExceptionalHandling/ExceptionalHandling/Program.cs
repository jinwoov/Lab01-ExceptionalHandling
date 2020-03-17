using System;

namespace ExceptionalHandling
{
    class Program
    {
        // Global Variable
        public static int choseProduct;
        public static int choseDivision;
        public static string whatsInArray;

        static void Main(string[] args)
        {
            try
            {
                string userName = MainMenu();
                StartSequence(userName);

            }
            catch (Exception e)
            {
                Console.WriteLine($"Your Error was {e.Message}");
            }
            finally
            {
                Console.WriteLine("The application is finished!");
            }
        }

        static string MainMenu()
        {
            Console.WriteLine(@"
                                #==================#
                                #  Exceptional App #
                                #   made by Jin    #
                                #==================#");
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            return userName;
        }
        static void StartSequence(string name)
        {
            try
            {
                // Declaring the variable to use it for Tryparse method
                int userValue;

                // Asking user to put array length
                Console.WriteLine("Enter a value that is greater than zero");
                bool userBool = Int32.TryParse(Console.ReadLine(), out userValue);
                while (!userBool)
                {
                    Console.WriteLine($"{name}, please enter numerical value!");
                    userBool = Int32.TryParse(Console.ReadLine(), out userValue);
                }
                int[] valueArray = new int[userValue];

                // To populate
                int[] populatedArray = Populate(valueArray);

                // To capture sum of array
                int totalValue = GetSum(populatedArray);

                // To capture product of array
                int productValue = GetProduct(valueArray, totalValue);

                // To capture quotient of array
                decimal quotientValue = GetQuotient(productValue);

                // Final result after all of the input
                Console.WriteLine($"Finale for {name}");

                /// Array Size
                Console.WriteLine($"Your array size is: {userValue}");

                /// What is in Array
                Console.Write($"The numbers in the array are {whatsInArray}");

                Console.WriteLine("");
                /// Total sum value
                Console.WriteLine($"The sum of the array is {totalValue}");

                /// What is product
                Console.WriteLine($"{totalValue} * {choseProduct} = {productValue}");
                
                /// division
                Console.WriteLine($"{productValue} / {choseDivision} = {quotientValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("You had formatting error");
            }
            catch (OverflowException)
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
                 Console.WriteLine($"Please enter numerical value! {i+1}/{numArray.Length}");
                 userResponse = Console.ReadLine();
                 numArray[i] = Convert.ToInt32(userResponse);
            }
            // Using the array output for later use
            whatsInArray = String.Join(", ", numArray);
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
                throw new Exception($"Value {sum} is too low");

            return sum;
        }

        static int GetProduct(int[] numArray, int total)
        {
            try
            {
                // First let the user pick a number and converting it's type to integer
                Console.WriteLine($"Please pick a number between 1 and {numArray.Length}");
                int chosenNumber = Convert.ToInt32(Console.ReadLine());
                // Multiplying array index of chosen number from user with total of populated array elements
                int product = total * numArray[chosenNumber-1];
                choseProduct = numArray[chosenNumber-1];
                return product;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Sorry your index was out of range");
                throw;
            }
        }

        static decimal GetQuotient(int product)
        {
            try
            {
                // Asking the user to enter a input that will be used to divide the product result
                Console.WriteLine($"Please enter a number to divide {product} by ...");
                int dividableNumber = Convert.ToInt32(Console.ReadLine());
                choseDivision = dividableNumber;
                // using Decimal Divide to divde two number 
                Decimal finalValue = Decimal.Divide(product, dividableNumber);
                return finalValue;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Hellow you can't enter 0 -_-^");
                return 0;
            }
            
        }
    }
}
