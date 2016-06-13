using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vaulter_Dice_Game
{

    class Dice
    {
        //initial public variables of the dices
        public int dice1;
        public int dice2;
        public int dice3;
        public int diceSum;
        public bool playerWon;
        Random rand;
  
        public Dice()
        { 
        //Constructor
        }

        
        public Dice(Random generator)
        {
            rand = generator;
            //function to call the 3 dices
            RollTheDice();
        }

        public void RollTheDice()
        {
            dice1 = rand.Next(1, 7);
            dice2 = rand.Next(1, 7);
            dice3 = rand.Next(1, 7);
            //function to sum all the dices
            AddTheDices();
        }

        //sum all the dices
        public void AddTheDices()
        {
            diceSum = dice1 + dice2 + dice3;
        }

        //function that returns if the player won or lost the bet
        public void BetCheck(string name,int choosenDice,int choosenSum1, int choosenSum2, bool isTriple, bool isOdd, bool isEven)
        {
            //check if the dice are triples, if not proceed to check the rest
            #region If
            
            
            if (dice1 == dice2 && dice2 == dice3)
            {
                if (dice1 == choosenDice)
                {
                    playerWon = true;
                }
                else
                {
                    playerWon = false;
                }
                if (isTriple == true)
                {
                    playerWon = true;
                }
            }//if dice
            #endregion
  
            #region Else
            else
            {
                //testing the Double n's bet
                if ((dice1 == dice2 || dice2 == dice3 || dice3 == dice1) && isTriple == false)
                {
                    if (dice1 == choosenDice && dice2 == choosenDice || dice1 == choosenDice && dice3 == choosenDice || dice2 == choosenDice && dice3 == choosenDice)
                    {
                        playerWon = true;
                    }
                    else
                    {
                        playerWon = false;
                    }
                    /*
                    if (dice1 == dice2 && dice2 == dice3)
                    {
                        playerWon = false;
                    }
                    */
                }

                //testing the Big bet
                if (diceSum > 10 && diceSum < 17)
                {
                    if (name == "Big")
                    {
                        playerWon = true;
                    }
                    /*
                    if (dice1 == dice2 && dice2 == dice3 || betValue != 1)
                    {
                        playerStatus = false;
                    }
                    */
                }

                //testing the Small Bet
                if (diceSum > 3 && diceSum < 11)
                {
                    if (name == "Small")
                    {
                        playerWon = true;
                    }
                    /*
                    if (dice1 == dice2 && dice2 == dice3 || betValue != 2)
                    {
                        playerStatus = false;
                    }
                    */
                }

                //testing the Odd bet
                if (diceSum % 2 != 0 && isOdd == true)
                {
                    playerWon = true;
                }

                //testing the Even bet
                if (diceSum % 2 == 0 && isEven == true)
                {
                    playerWon = true;
                }

                //testing the sum of the dices
                if (diceSum == choosenSum1 || diceSum == choosenSum2)
                {
                    playerWon = true;
                }
   
            }//else
            #endregion

        }

    }


}
