using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulter_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the Window to fit the image
            Console.SetWindowSize(70, 70);
            
            //placing the Pipboy ASCII image
            #region PipBoy Image
            Console.WriteLine("                                         ,▄▄▄                              ");
            Console.WriteLine("                                       ▄▓█▀▀▀▀▀█▄        ");
            Console.WriteLine("               ▄▄▓█`       ,▄▄▓▓▄▄▄▄▄@██▀!√√√√√└▀█▄        ");
            Console.WriteLine("            .▓█▀██       #█▀▀└:.!╙▀▀██▀:√√√√√√√√√!▀▀█▓▓▄▄     ");
            Console.WriteLine("           ╓█▀..▀█▓▄▄▄▄▓▀▀:√√√√√√√√√√√√√√√√√√√√√√√√√░░▀▀██▄      ");
            Console.WriteLine("           ██.√√√!▀▀▀▀▀:√√√√√√√√√√√√√√√√√√√√√√√√√√√√╠░░░░▀█▄         ");
            Console.WriteLine("          █▌√√√√√√√√√√√√√▄▄▄▄▄.√√√√√√√╓▄▄▄.√√√√√√√√╠░░░░░╙█▄           ");
            Console.WriteLine("           ██.√√√√√√√√√▄#█▀╙`╙▀█▓▄▄▄@▓██████▄.√√√√√╠░░░░░░░╙█▓▄         ");
            Console.WriteLine("         ┌████:√√√√√(▄█▀╙       └▀▀▀▀└   └▀▀██,√√╓╢░░░░░░░░░░▀██▄          ");
            Console.WriteLine("         ██:√╙▀▓▄▄▓▓▀▀                      └██▄░░░░░░░░░░░░░░░██▄          ");
            Console.WriteLine("         █▌√√╓██▀  ▄▄@╕                       ▀▀█▓▀▀▀▀▀▀███▄░░░░██▄         ");
            Console.WriteLine("         ██▄▓█▀  ╙▀▀▀▀▀                 ,▄               ▀███░░░░██▄        ");
            Console.WriteLine("          ███`                         ▓███,     .        ███░░░░║██        ");
            Console.WriteLine("         ▓█▀     ,▄                     └▀██▄            ▄██▀░░░░░██      ");
            Console.WriteLine("        ██▀     ███¼        ,              ▀▀        ╓@██▀▀░░░░░░░██        ");
            Console.WriteLine("       ██▀     ▐███       ╓█▀        ▄▄,          .  ▄╙▀█░░░░░░░░╟██        ");
            Console.WriteLine("      ▐█▌       ▀▀└     .▓█└        #███          .  ╙█▓,▀█░░░░░░██▌        ");
            Console.WriteLine("      ██              ▄▓█▀          ███▌          . .▄,▀█▄╙█░░░░███         ");
            Console.WriteLine("     ╟█▌            #██▀            ╙▀▀           .  ▀█▓,█▄╙█░░███          ");
            Console.WriteLine("     ██─            ███                             ▓▄,▀█▄█,█░███`          ");
            Console.WriteLine("     ██             ╙███                         .   ▀█▄╙█Ö█████            ");
            Console.WriteLine("     ██    ,#         ╙╙                         . ╙█▄ ▀ ╙████▀             ");
            Console.WriteLine("     ██  ╒███▄▄                  ▐█▄            .   ╙▀  .@███┘              ");
            Console.WriteLine("     ██▌  ██▄ └╙▀▀#╦▄▄▄▄▄▄▄▄▄▄▄▄#████▄         .         ╙███               ");
            Console.WriteLine("     ▐██   ▀ ▀▓▄,     `└╙└└ .      ███▌        .          ╟██               ");
            Console.WriteLine("      ██▌      ╙▀█▓▄▄▄,   .,▄▄▄▓▓▀▀╙██        .          .███               ");
            Console.WriteLine("      └██▄        └▀▀▀███▀▀▀▀╙            ..          ▄███                ");
            Console.WriteLine("       ╙██▄       Ñ▓▓▓▓µ                   ..    ▄▓▓▓▓███▀`                 ");
            Console.WriteLine("        └██▄        `└└                  ..    ▄███▀└└                      ");
            Console.WriteLine("          ▀██▄                          .   ▄▓██▀└                          ");
            Console.WriteLine("            ▀█▓▄                     ..  ▄▓██▀╙                             ");
            Console.WriteLine("              ╙▀█▄,                .╓▄▓██████                               ");
            Console.WriteLine("                 ╙██▓▄         ...   '' ▄██▀                                ");
            Console.WriteLine("                  ╙█████▓▓▄▄▄▄      .▄▄██▀'                                 ");
            Console.WriteLine("                    ▀█████▄▄▄▄▄▄▄▄▓████▀                                    ");
            Console.WriteLine("                       ╙▀▀▀██████▀▀▀╙           ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░   VAULT 235 DICE GAME   ░░░░░░░░░░░░░░░░░░░░░░░░  ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pipboy| Welcome to Vault 235 Dice Game System.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Loading...");
            Console.WriteLine("Loading...");
            Console.WriteLine("Loading...");
            Console.WriteLine("Loading complete.");
            Console.WriteLine("");

            #endregion

            #region Initial Variables

            // variable to check if the player wants to keep playing the game
            bool myGameIsDone = false;
            //initial money of the player
            int playerBottleCaps = 200;

            int betInput;
            int betMoney;

            #endregion

            #region Game

            while (!myGameIsDone)
            {
                #region Variables
                //initial bet of the player
                string bet = "None";
                bool validInput = false;
                bool validMoneyInput = false;
                betInput = 0;
                betMoney = 0;


                #endregion

                #region Bet List

                //choosing the type of bet
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pip Boy | Choose your type of bet");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("");
                Console.WriteLine("1. Big              2. Small        3. Odd          4. Even");
                Console.WriteLine("5. All 1s           6. All 2s       7. All 3s       8. All 4s");
                Console.WriteLine("9. All 5s           10. All 6s      11. Double 1s   12. Double 2s");
                Console.WriteLine("13. Double 3s       14. Double 4s   15. Double 5s   16. Double 6s");
                Console.WriteLine("17. Any triples     18. 4 or 17     19. 5 or 16     20. 6 or 15");
                Console.WriteLine("21. 7 or 14         22. 8 or 13     23. 9 or 12     24. 10 or 11");
                Console.WriteLine("");
                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("");
                
                #endregion

                #region Bet Choice

                while (validInput == false)
                {
                    try 
                    {
                        //read the type choosen
                        string input = Console.ReadLine();
                        betInput = Convert.ToInt32(input);
                        validInput = true;

                        //check if the number is bellow or bigger than the correct choice
                        if (betInput < 1 || betInput > 24)
                        {
                            Console.WriteLine("Pip Boy | Sorry, that type does not exist.");
                            Console.WriteLine("Pip Boy | Please choose a valid type of bet");
                            validInput = false;
                        }
                    }

                    catch 
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pip Boy | Sorry, that type does not exist.");
                        Console.WriteLine("Pip Boy | Please choose a valid type of bet");
                        validInput = false;
                    }

                }

                Bet newBet = new Bet(betInput);
  
                #endregion

                #region Money Bet

                //the amount the player would like to bet
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("Pip Boy | " + newBet.betName + " was chosen");
                Console.WriteLine("");
                Console.WriteLine("Pip Boy | You have: "+playerBottleCaps+" bottlecaps");
                Console.WriteLine("");
                Console.WriteLine("Pip Boy | How many bottlecaps would you like to bet?");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;

                while (validMoneyInput != true)
                {
                    try
                    {
                        string betMoneyInput = Console.ReadLine();
                        betMoney = Convert.ToInt32(betMoneyInput);
                        validMoneyInput = true;
                        //check if the player is betting above the allowed
                        while (betMoney > playerBottleCaps)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Pip Boy | You don't have that many bottlecaps.");
                            Console.WriteLine("Pip Boy | Please bet again.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            validMoneyInput = false;
                            betMoney = 0;
                        }
                    }

                    catch 
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pip Boy | Invalid command, please insert a valid one.");
                        validMoneyInput = false;
                    }
                }

                //subtraction from the initial player money
                playerBottleCaps -= betMoney;
                Console.WriteLine("");

                Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                Console.WriteLine("");
                
                #endregion

                #region Dice Rolling


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pip Boy | Rolling the dice. Wait one second please.");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rolling the first dice...");
                Console.WriteLine("...");
                Console.WriteLine("Rolling the second dice...");
                Console.WriteLine("...");
                Console.WriteLine("Rolling the third dice...");
                Console.WriteLine("...");
                Console.WriteLine("");

       
                //Random generator
                Random generator = new Random();
               
                //roll the dice and generate 3 random values for each dice
                /*
                int dice1 = generator.Next(1, 7);
                int dice2 = generator.Next(1, 7);
                int dice3 = generator.Next(1, 7);
                */

                Dice newDiceRoll = new Dice(generator);
                
                //tells the player the number on each dice
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Pip Boy | The first dice value is: " + newDiceRoll.dice1);
                Console.WriteLine("");
                Console.WriteLine("Pip Boy | The second dice value is: " + newDiceRoll.dice2);
                Console.WriteLine("");
                Console.WriteLine("Pip Boy | The third dice value is: " + newDiceRoll.dice3);
                Console.WriteLine("");
                

                //add each dice to the total sum and returns to the player the total sum
                //diceSum = dice2 + dice1 + dice3;

                Console.WriteLine("Pip Boy | The sum of the three dices is: " + newDiceRoll.diceSum);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Loading...");
                Console.WriteLine("Loading...");
                Console.WriteLine("Loading...");
                Console.WriteLine("");
                
                #endregion

                #region Check the Dices

                //check the result of the dices based on the Bet Class choices
                newDiceRoll.BetCheck(newBet.betName,newBet.choosenDice,newBet.choosenSum1,newBet.choosenSum2,newBet.tryTriple,newBet.tryOdd,newBet.tryEven);
                
                #endregion

                #region Bet Results

                //check if the player won the round
                if (newDiceRoll.playerWon == true) 
                {
                    playerBottleCaps += newBet.betOdds * betMoney;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pip Boy | Your " + newBet.betName + " bet won! You received: $" + newBet.betOdds * betMoney);          
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Pip Boy | Your " + newBet.betName + " bet lost!");
                    Console.WriteLine("Pip Boy | You have: " + playerBottleCaps + " bottlecaps.");
                }

                #endregion

                //check if the playey wants to play again or if he broke the house
                #region Money Result

               //check if the player lost all his money
                if (playerBottleCaps<1)
                {
                    Console.WriteLine("Pip Boy | You lost all your bottlecaps? Try again? Y or N?");
                    string newTry = Console.ReadLine();
                    if (newTry.ToUpper() == "Y")
                    {
                        playerBottleCaps = 200;
                        myGameIsDone = false;
                    }
                    if (newTry.ToUpper() == "N")
                    {
                        myGameIsDone = true;
                    }
                }

                //check if the player broke the house
                else if (playerBottleCaps>100000)
                {

                    Console.WriteLine("Pip Boy | The software has crashed!  Do you want to give it another shot? Y or N?");
                    string newTry = Console.ReadLine();

                    if (newTry.ToUpper() == "Y")
                    {
                        playerBottleCaps = 200;
                        myGameIsDone = false;
                    }
                    if (newTry.ToUpper() == "N")
                    {
                        myGameIsDone = true;
                    }

                }

                //check if the player wants to play again
                else 
                {
                    Console.WriteLine("Pip Boy | Do you want to give it another shot? Y or N?");
                    string newTry = Console.ReadLine();
                    

                    if (newTry.ToUpper() == "Y")
                    {
                        myGameIsDone = false;
                    }
                    if (newTry.ToUpper() == "N")
                    {
                        myGameIsDone = true;
                    }

                }
                #endregion

                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("");

            }//Region Game
            #endregion
        
        }//main

    }//class program

}//namespace
           