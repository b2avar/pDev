using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number :");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("number is : " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            /* finally
            {
                Console.Write("Process completed.");
            } */

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("You entered an empty value.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("The data type is not suitable");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("You entered a value that is too large or too small.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("The operation completed successfully");
            }


        }
    }
}
