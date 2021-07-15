using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tevin Hamilton
             * 03/07/2018
             * Logic and Loops 
             * */
            Console.Clear();

            //Problem #1

            //creating a array
            int[] gradeArray = new int[2];
            // 1st promt to the user 
            Console.WriteLine("Please enter your first grade as a whole number ");
            string firstGradeString = Console.ReadLine();
           //creating a while loop to re-promt the user if 
            while (!(int.TryParse(firstGradeString, out gradeArray[0])))
            {
                Console.WriteLine("please type in your grade as a whole number.");
                firstGradeString = Console.ReadLine();
            }
            //2nd promt to the user 
            Console.WriteLine("please enter your second grade as a whole number");
            string secondGradeString = Console.ReadLine();
            

            while (!(int.TryParse(secondGradeString, out gradeArray[1] )))
            {   
                Console.WriteLine("please type in your grade as a whole number.");
                secondGradeString = Console.ReadLine();
            }

            if (gradeArray[0] >= 70 && gradeArray[1] >= 70)
            {
                Console.WriteLine("Congrat, both are passing\r\n");
            }
            else if  (gradeArray[0] < 70 || gradeArray[1] < 70)
            {
                Console.WriteLine("One or more grades are failing, try harder next time!\r\n"	);
                Console.WriteLine("Please study or review your feedback");
            }
            /* TEST for problem 1 
             * first test- grade 1 95 grade 2 85 results- Congrat both grades	are	passing
             * second test- grade 1 82 grade 2 68 results -One or  more  grades  are failing, try harder next time!"
             * third test - grade 1 70 grade 2 90 result - Congrat both grades	are	passing=
             * */

            //Problem #2
            Console.WriteLine("\r\nplease type your age using whole numbers");
            string brunchString = Console.ReadLine();
            int brunch;

            while (!(int.TryParse(brunchString, out brunch)))
            {
                Console.WriteLine("ERROR!!!\r\nPlease type in your age using whole numbers. ");
                brunchString = Console.ReadLine();
            }

            if ((brunch > 55) || (brunch <10))
            {
                Console.WriteLine("Your cost for brunch is $10.00");
            }
           
            else if  (brunch >= 10)
            {
                Console.WriteLine("your cost of the Brunch is 15.00 ");
            }

            /*test inputs 
             * age 57 $10.00
             * age 39 $15.00
             * age 8 10.00
             * age 10 $15.00
             * age 24 15.00
             * */





            //Problem #3 
            Console.WriteLine("\r\nPlease enter the amount of DVDs you own.\r\n");
            string dvdString = Console.ReadLine();
            int dvd;
            while (!(int.TryParse(dvdString, out dvd)))
            {
                Console.WriteLine("last entry is incrorrect\r\n please enter a whole number ");
                dvdString = Console.ReadLine();

            }
            Console.WriteLine("Please enter the amount of Blu-Rays you own.\r\n");
            string bluRaysString = Console.ReadLine();
            int blueRay;
            while (!(int.TryParse(bluRaysString, out  blueRay)))
            {
                Console.WriteLine("last entry is incrorrect\r\n please enter a whole number ");
                bluRaysString = Console.ReadLine();

            }
            Console.WriteLine("Please enter the amount of Ultra Violets that you own.\r\n");
            string ultraVioletsString = Console.ReadLine();
            int ultraViolets;
            while (!(int.TryParse(ultraVioletsString, out ultraViolets)))
            {
                Console.WriteLine("last entry is incrorrect\r\n please enter a whole number ");
                ultraVioletsString = Console.ReadLine();
            }


            int[] movies = new int[3] { dvd, blueRay, ultraViolets };

            int totel = 0;


            for (int i = 0; i < movies.Length; i++)
            {
                totel += movies[i];
            }
            if (totel>=100)
             {
               Console.WriteLine($"Wow, i am impressed with your collection you have a totel of {totel} movies\r\n");
             }
            else
            {
              Console.WriteLine($"you have a totel of {totel} movies in your collection");
            }
            /* Test!
             * dvd-45 + blu-ray-15 + ultraViolets-2 =62
             * dvd-60 + blu-ray-75 + ultraViolets-45 =180
             * dvd 75 + blu-ray 75 + ultraViolets 2 =
             * */


            //Problem 4 
            Console.WriteLine("\r\nWhat is your gift card amount ");
            string giftCardString = Console.ReadLine();
            decimal giftCard;
            while (!(decimal.TryParse(giftCardString, out giftCard))) 
            {

                Console.WriteLine("please enter the correct amount");

                giftCardString = Console.ReadLine();
            }
            decimal item = 0;
            while (giftCard >= 0)
            {
                
                Console.WriteLine("what is the price of your item  ");
                string itemString = Console.ReadLine();
                
                while (!(decimal.TryParse(itemString, out item)))
                {
                    Console.WriteLine("please enter a vaild number.");

                    itemString = Console.ReadLine();
                }
                giftCard -= item;
                Console.WriteLine($"your remaining blance on youer gift card is {giftCard}");

            }
             


            Console.WriteLine($"With your last purchase of {item}, you have used your gift card up and still owe {giftCard * -1}  ");
            
            /* test
             * gift card amount -30.00, first purchase 5.00 second purchase 10.50 third purchase 16.00, 30 - 5.00 - 10.50 -16.00 = 1.50 still owe .
             * GCA 100.00, FP 25.00, SP 35.00, TP 50.00 = $15.00 owed 
             * */


        }
    }
}
