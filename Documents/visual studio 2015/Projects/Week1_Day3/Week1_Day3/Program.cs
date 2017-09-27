using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {


            //int firstNumber = 2;
            //int secondNumber = 6;

            //if (firstNumber > secondNumber)
            //{
            //    // IF the statement above is TRUE...do something
            //    Console.WriteLine("Try again!");
            //}

            //else
            //{ 
            //    // do something else
            //    Console.WriteLine("Good job!");
            //}


            //Console.WriteLine("What day is today?");

            //string userAnswer = Console.ReadLine();

            //if(userAnswer == "Monday") ;
            //{
            //    Console.WriteLine("Back to work!");
            //}


            //else if(userAnswer == "Friday") ;

            //{
            //    Console.WriteLine("TGIF");
            //}

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());

            //if (userAge <= 1)
            //{
            //    Console.WriteLine("You're just a baby!");
            //}
            //else if (userAge > 1 && userAge < 4)
            //{
            //    Console.WriteLine("Yay todlers!");
            //}
            //  else if(userAge >= 4 && userAge < 13)
            //{
            //    Console.WriteLine("Enjoy your childhood!");
            //}
            //else if(userAge > 13 && userAge < 65)
            //{
            //    Console.WriteLine("Life is akward!");
            //}
            //else if(userAge >= 65 && userAge < 100)
            //{
            //    Console.WriteLine("Enjoy your retirement!");
            //}
            //else 
            //{
            //    Console.WriteLine("That's REALLY not your age!");
            //}



            Console.WriteLine("How many points did you earn?");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("YOU LOSE!");

                    break;
                case 1:
                    Console.WriteLine("Needs practice!");
                    break;
                case 2:
                    Console.WriteLine("On target!");
                    break;
                case 3:
                    Console.WriteLine("Want a cookie?");
                    break;
                case 4:
                    Console.WriteLine("Overachiever!");
                    break;
                case 5:
                    Console.WriteLine("CHEATER!");
                    break;
                default:
                    Console.WriteLine("Invalid score entered.");
                    break;



            }





                
            


        }
    }
}
