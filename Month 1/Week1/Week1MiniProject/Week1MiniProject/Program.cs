using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _1WeekMiniProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello and Welcome!");
            Console.WriteLine("This is a creation of me, rhouge, as my first mini-project after learning programming for a week");
            Console.WriteLine(" ");
            Console.WriteLine("To start, I would first like to know your name and age");
            Console.WriteLine(" ");
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            greet(Name, Age);

            // secret word guessing game

            Console.WriteLine(" ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                    Guessing Game");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Now, let's start this with a little game");
            Console.WriteLine("I would like you to guess what my favorite flavor is");
            Console.WriteLine(" ");

            Console.WriteLine("Here are the choices: ");

            string[] choices = { "Chocolate", "Vanilla", "Rocky Road", "Cookies and Cream" };
            Array.Sort(choices);
            foreach (string i in choices)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("You will only have three(3) guesses");
            Console.WriteLine("  ");

            string secretWord = "COOKIES AND CREAM";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guess = guess.ToUpper();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You have failed to guess my favorite flavor, it's Cookies and Cream");
            }
            else
            {
                Console.WriteLine("Wow! you have guessed my favorite flavor, nice");
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("");
            Console.WriteLine("Now, let us move one to the next program");
            Console.WriteLine("");

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("             Random Number Guessing Game");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("In this program, you will be guessing a random generated number");
            Console.WriteLine("Each guess you make, the program will tell you whether your guess");
            Console.WriteLine("is high or low, helping you guess the number");

            // rng guessing game

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int rngnumber;
            int nguess;
            int nguesses;
            string response;

            while (playAgain)
            {
                nguess = 0;
                nguesses = 0;
                response = "";
                rngnumber = random.Next(min, max + 1);

                while (nguess != rngnumber)
                {
                    try
                    {
                        Console.WriteLine("");
                        Console.Write("Guess a number between " + min + " - " + max + ": ");
                        nguess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + nguess);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please only enter a number");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Something went wrong");
                    }

                    if (nguess > rngnumber)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(nguess + " is too high!");
                    }
                    else if (nguess < rngnumber)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(nguess + " is too low!");
                    }
                    nguesses++;
                }
                Console.WriteLine("");
                Console.WriteLine("Number: " + rngnumber);
                Console.WriteLine("You did it!");
                Console.WriteLine("You guessed it in " + nguesses + " guesses");
                Console.WriteLine("");

                while (response != "Y" && response != "N")
                {
                    Console.Write("Would you like to play again? (press Y if yes, Press N if no): ");
                    response = Console.ReadLine();
                    response = response.ToUpper();
                }
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("I hope you liked it");
            Console.WriteLine("Let's head to the next program!");
            Console.WriteLine("");


            // Rock, paper, scissors game

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("              Rock, Paper, Scissors Game");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("In this program, you will be able to play the infamous game rock, paper and scissors");
            Console.WriteLine("you are going to play againts a computer that randomly generates rock, paper or scissors");
            Console.WriteLine("now, if you're ready, Have fun and Enjoy!");
            Console.WriteLine("");


            string player;
            string computer;
            string responseRPS;
            bool playAgainRPS = true;
            Random randomRPS = new Random();

            while (playAgainRPS)
            {
                player = "";
                computer = "";
                responseRPS = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("");
                    Console.Write("Enter ROCK, PAPER, or SCISSOR: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (randomRPS.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("It's a Draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a Draw!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("it's a Draw!");
                        }
                        break;
                }

                while (responseRPS != "Y" && responseRPS != "N")
                {
                    Console.WriteLine("");
                    Console.Write("Would you like to play again? (press Y if yes, Press N if no): ");
                    responseRPS = Console.ReadLine();
                    responseRPS = responseRPS.ToUpper();
                }
                if (responseRPS == "Y")
                {
                    playAgainRPS = true;
                }
                else
                {
                    playAgainRPS = false;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you for playing! hope you enjoyed");
            Console.WriteLine("Let's head to my last program");
            Console.WriteLine("");

            // Calculator

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("                    Calculator");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Hello, " + Name + "welcome to my last program, the calculator");
            Console.WriteLine("this is just a simple calculator I have came up with, using the current knowledge i have");
            Console.WriteLine("so expect some issues, but regardless, I hope you'll like it, Enjoy!");


            Console.WriteLine("before we head to the calculator, I will show you a little math game");
            Console.WriteLine("");
            Console.WriteLine("You will enter three (3) different numbers and my program will identify");
            Console.WriteLine("which one is the largest, the smallest and then my program will sum up all the numbers");
            Console.WriteLine("");

            try
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a 2nd number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a 3rd number: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                double[] myNum = { num1, num2, num3 };
                Console.WriteLine("The largest number is: " + myNum.Max());
                Console.WriteLine("The smallest number is: " + myNum.Min());
                Console.WriteLine("The sum of those three number is: " + myNum.Sum());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }

            Console.WriteLine("");
            Console.WriteLine("Did you like it?");

            Console.WriteLine("Now, let's use the calculator");
            Console.WriteLine("");
            Console.WriteLine("through my calculator you will be able to do basic operations");
            Console.WriteLine("such as Addition, Subtraction, Multiplication, Division and even Exponent");
            Console.WriteLine("");

            do
            {
                Console.Write("Enter a number: ");
                Double Num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter an Operator(+, -, *, /): ");
                string op = Console.ReadLine();
                Console.Write("Enter another Number: ");
                Double Num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine("The answer is: " + Num1 + Num2);
                }
                else if (op == "-")
                {
                    Console.Write("The answer is: ");
                    Console.Write(Num1 - Num2);
                    Console.WriteLine("");
                }
                else if (op == "*")
                {
                    Console.WriteLine("The answer is: " + Num1 * Num2);
                }
                else if (op == "/")
                {
                    Console.WriteLine("The answer is: " + Num1 / Num2);
                }
                else
                {
                    Console.WriteLine("Invalid Operator");
                }
                Console.Write("Would you like to continue using this calculator? (press Y if yes, press N if no and head to the exponent calculator): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("");
            Console.WriteLine("");

            do
            {
                try
                {
                    Console.Write("Enter a base number: ");
                    int basenum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an exponent number: ");
                    int pownum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Pow(basenum, pownum));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please input a number");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong");
                }
                Console.WriteLine("Do you want to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("");
            Console.WriteLine("That's all for now!");
            Console.WriteLine("Thank you!");

            Console.WriteLine("");
            Console.WriteLine("PS. This is the combination of everything I have learned in a week");
            Console.WriteLine("    using C#, excluding OOP, inheritance, polymorphism. adn other");
            Console.WriteLine("    things that is related to that. For the reason that I can't think");
            Console.WriteLine("    of any fun game to do with those");
            Console.WriteLine("    I am also aware with the minor issues, such as some of the exceptions");
            Console.WriteLine("    specifically format exceptions, but I left it that way, since the current");
            Console.WriteLine("    time I am doing this, I am busy with schoolworks and need to finish this already.");


            Console.ReadLine();
        }

        static void greet(string name, int age)
        {
            string result;

            if (age < 18)
            {
                result = ("you are not old enough, but I would still let you stay");
            }
            else
            {
                result = ("you are old enough");
            }
            Console.WriteLine("Hello " + name + " you are " + age + " and " + result);

        }
    }

}