using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Prompts user to enter the students grade
            Console.WriteLine("What is the students numeric grade");
           // Makes grade a double which lets it be a number
            double grade = Convert.ToDouble(Console.ReadLine());

            // Makes any number 89.5 and above output an A 
            if (grade > 89.5)
            {
                Console.WriteLine("A");
            }
            else
            {
                // Makes any number between 79.5 and 89.4 a B
                if (grade > 79.5)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    // Makes any number between 69.5 and 79.4 a C
                    if (grade > 69.5)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        // Makes any number between 59.5 and 69.4 a D
                        if (grade > 59.5)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            // Anything below a 59.4 becomes an F
                            Console.WriteLine("F");
                        }
                    }

                }

            }
           // Makes the system read the code
            Console.ReadLine();
        }
    }
}
