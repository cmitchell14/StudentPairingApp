using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPairingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() { };
            string student;
            bool exit = false;


            do
            {

                Console.Write("Please type a student's name to add them to the list: ");
                student = Console.ReadLine();
                students.Add(student);
                Console.WriteLine($"{student} has been added to the list.\n\nWould you like to add another student?  Y/N");

                ConsoleKey choice = Console.ReadKey().Key;
                bool exit2 = false;
                while (!exit2)
                {
                    switch (choice)
                    {
                        case ConsoleKey.Y:
                            exit2 = true;
                            break;
                        case ConsoleKey.N:
                            exit = true;
                            exit2 = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option.  Please choose again.");
                            break;
                    }

                }

            } while (!exit);


           


        }
    }
}
