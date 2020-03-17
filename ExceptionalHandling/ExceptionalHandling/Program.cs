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
    }
}
