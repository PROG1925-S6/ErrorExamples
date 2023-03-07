/*   ErrorExamples
 *   Demonstration on the use of try, catch, and finally
 *   
 *   Revision History:
 *       Tony Theo..., 2023.03.06: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryCatchExamples();
        }

        public static void TryCatchExamples()
        {
            int num1, num2, answer;

            try
            {
                Console.Write("Enter a number value (1-100): ");
                num1 = Convert.ToInt16(Console.ReadLine());

                if(num1 < 1 || num1 > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.Write("Enter a second number value (1-100): ");
                num2 = Convert.ToInt16(Console.ReadLine());

                answer = num1 / num2;

                Console.WriteLine($"{num1} / {num2} = {answer}");
            }
            catch (FormatException) 
            {
               // Console.WriteLine(ex.Message);
                Console.Write("That is not a number!!! ");
            }
            catch (OverflowException)
            {
                //Console.WriteLine(ex.Message);
                Console.Write("Hey There. That number is too big, (or too small)");
            }
            catch(DivideByZeroException)
            {
                Console.Write("You can't divide by 0");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Write("Value must be between 1-100");
            }
            finally
            {
                Console.WriteLine("Press any key to exit");
            }


            Console.ReadKey();
        }
    }
}
