using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string check;

            do
            {

                Console.WriteLine("Please enter an integer.");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Squared");
                for (int power = 1; power <= num; power++)
                    Console.WriteLine("{0}^{1} = {2:N0} ",
                        num, power, (long) Math.Pow(num, power));

                Console.WriteLine("Cubed");
                for (int power = 1; power <= num; power++)
                    Console.WriteLine("{0}^{1} = {2:N0}",
                        num, power, (long) Math.Pow(num, power) * power);

                




                ////Console.WriteLine("Squared using method");
                //for (int power = 1; power <= Square(num); power++)
                //    Console.WriteLine("{0} ^ {1} = {2:N0}", num, power, Square(num));

                num = 0;
                Console.WriteLine("Would you like to try again? {Y/N}");
                check = Console.ReadLine().ToLower();

            }
            while (check == "y");

        }

        public static int Square(int x)
        {
            int result = x * x;
            return result;
        }

        public static int Cube(int x)
        {
            int result = x * x * x;
            return result;
        }


    }
}
