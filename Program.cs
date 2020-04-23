using System.Security.AccessControl;
/*using Internal.Runtime.Augments;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Task3
{
    class Program
    {
        class RandomGenerator
        {
            static void Main(string[] args)
            {
                Random rnd = new Random();
                int secret_num1 = rnd.Next(1,10);
                int secret_num2 = rnd.Next(1,20);
                int secret_num3 = rnd.Next(1,50);

                int guess = 0;
                int guess_limit1 = 5;
                int guess_limit2 = 3;
                int guess_limit3 = 2;
                int guess_count = 0;
                string input ="";
                bool gameover = false;
                

                List<string> Level = new List<string>(3);
                Level.Add("1");
                Level.Add("2");
                Level.Add("3");

                Console.WriteLine("INSTRUCTION: There are three levels in this game. You would have 6 attempts to guess a secret number between 1 and 10 correctly at the Easy level; 4 attempts for numbers between 1 and 20 and 3 attempts for numbers between 1 and 50!");
                Console.WriteLine("Please enter a number to select a level; 1 for Easy, 2 for Medium and 3 for Hard: ");

                while (gameover==false)
                {
                    input= Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine("You have selected the Easy Level. Let's play...");
                    
                        if (guess_limit1 - guess_count !=0)
                        {
                            Console.WriteLine("Make a guess: ");
                            guess= int.Parse(Console.ReadLine());
                        }
                        
                        if (guess == secret_num1)
                        {
                            Console.WriteLine("Congratulations! You got the number right!! Well done!!!");
                            gameover= true;
                        }    
                            while (guess != secret_num1 && guess_count != guess_limit1)
                            
                            {
                                Console.WriteLine("You got it wrong!! You have " + (guess_limit1 -guess_count) + " attempt(s) left. Make another guess: ");
                                guess= int.Parse(Console.ReadLine());
                                guess_count++;
                            }    
                            if (guess != secret_num1 && guess_count == guess_limit1)
                            {
                                Console.WriteLine("You have made a maximum number of " + (guess_limit1 + 1) + " attempts for this level. The secret number is: " + (secret_num2) + ". YOU LOST. Better luck next time." );
                                gameover= true;
                            }
                    }        
                    if (input == "2")
                    {
                        Console.WriteLine("You have selected the Medium Level. Let's play...");
                    
                        if (guess_limit2 - guess_count !=0)
                        {
                            Console.WriteLine("Make a guess: ");
                            guess= int.Parse(Console.ReadLine());
                        }
                        
                        if (guess == secret_num2)
                        {
                            Console.WriteLine("Congratulations! You got the number right!! Well done!!!");
                            gameover= true;
                        }    
                            while (guess != secret_num2 && guess_count != guess_limit2)
                            {
                                Console.WriteLine("You got it wrong!!. You have " + (guess_limit2 -guess_count) + " attempt(s) left. Make another guess: ");
                                guess= int.Parse(Console.ReadLine());
                                guess_count++;
                            }    
                            if (guess != secret_num2 && guess_count == guess_limit2)
                            {
                                Console.WriteLine("You have made a maximum number of " + (guess_limit2 +1) + " attempts for this level. The secret number is: " + (secret_num2) + ". YOU LOST. Better luck next time." );
                                gameover= true;
                            }
                    }                
                    if (input == "3")
                    {
                        Console.WriteLine("You have selected the Hard Level. Let's play...");
                
                        if (guess_limit3 - guess_count !=0)
                        {
                            Console.WriteLine("Make a guess: ");
                            guess= int.Parse(Console.ReadLine());
                        }
                        
                        if (guess == secret_num3)
                        {
                            Console.WriteLine("Congratulations! You got the number right!! Well done!!!");
                            gameover= true;
                        }    
                            while (guess != secret_num3 && guess_count != guess_limit3)
                            
                            {
                                Console.WriteLine("You got it wrong!! You have " + (guess_limit3 -guess_count) + " attempt(s) left. Make another guess: ");
                                guess= int.Parse(Console.ReadLine());
                                guess_count++;
                            }    
                            if (guess != secret_num3 && guess_count == guess_limit3)
                            {
                                Console.WriteLine("You have made a maximum number of " + (guess_limit3 +1) + " attempts for this level. The secret number is: " + (secret_num3) + ". YOU LOST. Better luck next time." );
                                gameover= true;
                            }                                    
                    }                                                       
                }   
            }   
        }
    }
}
   
