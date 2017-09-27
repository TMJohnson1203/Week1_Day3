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

            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge <= 1)
            {
                Console.WriteLine("You're just a baby!");
            }
            else if (userAge > 1 && userAge < 4)
            {
                Console.WriteLine("Yay todlers!");
            }
              else if(userAge >= 4 && userAge < 13)
            {
                Console.WriteLine("Enjoy your childhood!");
            }
            else if(userAge > 13 && userAge < 65)
            {
                Console.WriteLine("Life is akward!");
            }
            else if(userAge >= 65 && userAge < 100)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else 
            {
                Console.WriteLine("That's REALLY not your age!");
            }









                
            


        }
    }
}
