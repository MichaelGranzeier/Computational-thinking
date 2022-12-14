using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            // Enter your solution here

            Console.WriteLine("Please write a number and then press enter.");
            string firstInput = Console.ReadLine();
            int inputOne = Convert.ToInt32(firstInput);
            Console.WriteLine("Please write a second number and then press enter.");
            string secondInput = Console.ReadLine();
            int inputTwo = Convert.ToInt32(secondInput);

            if (inputOne != inputTwo){
                Console.WriteLine("The numbers " + inputOne + " and " + inputTwo + " are not equal to each other.");
            }else{
                Console.WriteLine("The numbers " + inputOne + " and " + inputTwo + " are the same number.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here


            Console.WriteLine("Please enter a number and then press enter.");
            string firstInput = Console.ReadLine();
            int num = Convert.ToInt32(firstInput);
            int numTwo = num % 2;

            if (numTwo <= 0){
                Console.WriteLine(firstInput + " is an even number.");
            }else{
                Console.WriteLine(firstInput + " is an odd number.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here

            Console.WriteLine("Please enter a letter:");
            string let = Console.ReadLine();
            string lett = let.ToUpper();

            switch (lett){
                case "A":
                case "E":
                case "I":
                case "O":
                case "U":
                    Console.WriteLine("The letter " + lett + " is a vowel");
                    break;
                case "Y":
                    Console.WriteLine("The letter " + lett + " is sometimes a vowel");
                    break;
                default:
                    Console.WriteLine("The letter " + lett + " is a consonant");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            Console.WriteLine("Please enter a number:");
            string strOne = Console.ReadLine();
            int inputThree = Convert.ToInt32(strOne);
            Console.WriteLine("Please enter a second number:");
            string strTwo = Console.ReadLine();
            int inputFour = Convert.ToInt32(strTwo);

            if (inputThree > inputFour){
                Console.WriteLine(inputThree + " is the larger number");
            }else{
                Console.WriteLine(inputFour + " is the larger number");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            Console.WriteLine("Please enter a number and then press enter.");
            string InputOne = Console.ReadLine();
            int numThree = Convert.ToInt32(InputOne);
            int numFour = numThree % 3;

            if (numFour <= 0){
                Console.WriteLine(InputOne + " is divisible by 3");
            }else{
                Console.WriteLine(InputOne + " is not divisible by 3");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void RestaurantBill()
        {
            // At a restaurant, Mike and his three friends decided to divide the bill evenly.
            // If each person paid $13 then what was the total bill?
            // Use arithmetic operators and print the amount of the total bill to the console.

            // Returning to the above problem, replace hard-coded values of 4(number of diners)
            // and 13(cost per diner) with values provided by the user.

            // How nice!The restaurant is having Customer Appreciation Week.
            // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
            // Otherwise, they’ll receive a 5 % discount.

            Console.Clear();
            Console.WriteLine("RESTAURANT BILL\n");

            // Enter your solution here

            Console.WriteLine("please enter the number of prople splitting the bill.");
            string people = Console.ReadLine();
            double peopleTwo = Convert.ToDouble(people);
            Console.WriteLine("please enter the cost per person.");
            string cost = Console.ReadLine();
            double costTwo = Convert.ToDouble(cost);
            double total = peopleTwo * costTwo;

            if (total >= 50)
            {
                double disOne = total * .9;
                double dis = Math.Round(disOne, 2);
                Console.WriteLine("You earned a 10% discount. Your total bill is $" + dis);
            }
            else
            {
                double disTwo = total * .95;
                double disThree = Math.Round(disTwo, 2);
                Console.WriteLine("You earned a 5% discount. Your total bill is $" + disThree);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AgeCategory()
        {
            // You're responsible for providing a demographic report for your local school district based on age.
            // To do this, you're going to determine which 'category' each person fits into based on their age.
            // The person's age will determine which category they should be in:

            // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
            // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
            // From 12 to 14: 'Middle School'
            // From 15 to 18: 'High School'
            // From 19 to 22: 'College'
            // From 23 to 65: 'Working for the Man'
            // From 66 to 100: 'The Golden Years'
            // If the age of the person is less than 0 or more than 100 - it might be an alien
            // print: "This program is for humans".

            Console.Clear();
            Console.WriteLine("AGE CATEGORY\n");

            // Enter your solution here

            Console.WriteLine("Please enter your age.");
            string age  = Console.ReadLine();
            int Age = Convert.ToInt32(age);

            if (Age >= 0 && Age <= 2)
            {
                Console.WriteLine("Still in Mama's Arms");
            }
            else if (Age >= 3 && Age <= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (Age >= 5 && Age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (Age >= 12 && Age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (Age >= 15 && Age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (Age >= 19 && Age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (Age >= 23 && Age <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (Age >= 66 && Age <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here

            Console.WriteLine("Please write the word of a number from zero to ten.");
            string numW = Console.ReadLine();
            string numWo = numW.ToUpper();

            switch (numWo)
            {
                case "ZERO":
                    Console.WriteLine("0");
                    break;
                case "ONE":
                    Console.WriteLine("1");
                    break;
                case "TWO":
                    Console.WriteLine("2");
                    break;
                case "THREE":
                    Console.WriteLine("3");
                    break;
                case "FOUR":
                    Console.WriteLine("4");
                    break;
                case "FIVE":
                    Console.WriteLine("5");
                    break;
                case "SIX":
                    Console.WriteLine("6");
                    break;
                case "SEVEN":
                    Console.WriteLine("7");
                    break;
                case "EIGHT":
                    Console.WriteLine("8");
                    break;
                case "NINE":
                    Console.WriteLine("9");
                    break;
                case "TEN":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Next time pick a number between zero and ten");
                    break;
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            Console.WriteLine("Please write your first name and then press enter:");
            string nameOne = Console.ReadLine();
            Console.WriteLine("Please write your last name and then press enter:");
            string nameTwo = Console.ReadLine();
            int countOne = nameOne.Length;
            int countTwo = nameTwo.Length;

            if (countOne > countTwo)
            {
                Console.WriteLine("First is longer.");
            }else if (countOne.Equals(countTwo))
            {
                Console.WriteLine("Same-sizes!");
            }
            else
            {
                Console.WriteLine("Last must be longer!");
            }
            

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here

            Console.WriteLine("Please write a name and then press enter:");
            string nameThree = Console.ReadLine();
            Console.WriteLine("Please write a second name and then press enter:");
            string nameFour = Console.ReadLine();

            if (nameThree == nameFour){
                Console.WriteLine("The names are the same.");
            }else{
                Console.WriteLine("The names are different.");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here

            Console.WriteLine("Please type your first name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please type the name of where your were born:");
            string loc = Console.ReadLine();
            Console.WriteLine("Hi " + name + "! you were born in " + loc + ".");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
