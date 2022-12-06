using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MethodandTP
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
         
          Allparts();
          Console.WriteLine();
          PartII();
          Console.WriteLine();
          PartIII();



        }
        public static void PartIII()//
        {

        //Label
        label1:

            // Print Stars
            Console.WriteLine("please enter the number to get the stars");
            string userInput = Console.ReadLine();
            int number = 0;

            //TryParse returns true or false
            //Result gets stored into bool variable
            //Validate user's input
            bool convResult = Int32.TryParse(userInput, out number);

            //If the conversion is true, then execute the method
            if (convResult)
            {
                PrintStars(number);
            }
            else
            {
                //goto
                goto label1;
            }
            Console.ReadKey();

        }

        public static void Allparts()//....................................PART 1 ..................
        {
            Console.WriteLine("Part 1 \n");
            Part1();
            Part2();
            Part3();
            Part1();
            Part2();

        }
        public static void Part1()

        {

            Console.WriteLine("*********");
            Console.WriteLine(" *******");
            Console.WriteLine("  *****");
            Console.WriteLine("   ***");
            Console.WriteLine("    *");
        }
        public static void Part2()
        {
            Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");
        }
        public static void Part3()
        {
            Console.WriteLine("XXXXXXXXX");
        }
        public static void PartII() //.....................................PART 2...............
        {
            Console.WriteLine("\nPart 2 \n");

            //Solution 1
            //Sum 12 + 5

            double sum = Add(12, 5);
            //Output
            Console.WriteLine("1: Solution - " + sum);

            //Solution 2
            //Division 902 / 73

            double ninotwodiv = Divide(902, 73);
            //Output
            Console.WriteLine("2: Solution - " + Math.Round(ninotwodiv, 2));

            //Solution 3
            //Multiply 658 * 23

            double sixfive = multiply(658, 23);
            //Output
            Console.WriteLine("3: Solution - " + Math.Round(sixfive, 2));

            //Solution 4
            //Subtract 5 - 72;

            double Subt = Sub(5, 72);
            //Output
            Console.WriteLine("4: Solution - " + Subt);

            //Solution 5
            //72 * 3 / 4

            //Multiply 72 * 3
            double seventymul = multiply(72, 3);
            //seventymul divide 4
            double tota = Divide(seventymul, 4.0);
            //Output
            Console.WriteLine("5: Solution - " + tota);


            //Solution 6
            //17 + 42 * 76 - 19 / 12

            //fortymul = (42 * 76)
            double fortymul = multiply(42, 76);
            //nintendiv = (19 / 12)
            double nintendiv = Divide(19, 12.0);
            //ad = 17 + fortymul
            double ad = Add(17, fortymul);
            //sub = ad - nintendiv
            double final = Sub(ad, nintendiv);
            //Output
            Console.WriteLine("6: Solution - " + Math.Round(final, 2)); // Result//3207.42


            //Solution 7

            double fiftytwo = multiply(52.33, 84);

            //
            double eightytwo = multiply(82.7, fiftytwo);

            //
            double twelveDiv = Divide(12, 54.0);

            double fina = Sub(eightytwo, twelveDiv);
            Console.WriteLine("7: Solution - " + Math.Round(fina, 2));


            //Solution 8.
            //Math.Pi * (r * r) * (h / 3)(This was the volume of a right Circiular cone from our midterm.You can grab that equation to help)

            double radius = multiply(5, 5);

            double radiuss = multiply(Math.PI, 5);

            double radiusss = multiply(radius, radiuss);

            double threDiv = Divide(radiusss, 3);
            Console.WriteLine("8: Solution - " + Math.Round(threDiv, 2));






        }

        public static double Add(double num1, double num2)// Method 1 .............Add.................................
        {

            double sum = num1 + num2;
            return sum;

        }

        public static double Sub(double num1, double num2) // Method 2 ..............sub.........................
        {
            double Sub = num1 - num2;
            return Sub;

        }

        public static double multiply(double num1, double num2)// Method 3..............multi..............
        {
            double multiply = num1 * num2;
            return multiply;

        }
        public static double Divide(double number1, double number2)// Method 4..............division............

        {
            double divide = number1 / number2;

            return divide;


        }



        public static void PrintStars(int numOfStars)// Methods (Starts output)
        {
            for (int i = 0; i < numOfStars; i++)
            {
                Console.Write("* ");
            }
        }
         
        





    }



}//class
