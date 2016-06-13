using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vaulter_Dice_Game
{
    class Bet
    {
        //initial variables 
        public string betName;
        public int betOdds;
        public int betInput;
        public int choosenDice;
        public int choosenSum1;
        public int choosenSum2;
        public bool tryTriple = false;
        public bool tryOdd = false;
        public bool tryEven = false;

        //array of the names of the Bet
        string[] betArray = { "Big", "Small", "Odd", "Even", "All 1s", "All 2s", 
                             "All 3s", "All 4s", "All 5s", "All 6s", "Double 1s", 
                              "Double 2s","Double 3s", "Double 4s", "Double 5s", 
                              "Double 6s", "Any Triples", "4 or 17", "5 or 16", 
                              "6 or 15", "7 or 14","8 or 13", "9 or 12", "10 or 11"
                            };

        public Bet()
        {
            //Empty constructor
        }

        public Bet(int theInput)
        {
            betInput = theInput;
            betName = betArray[theInput - 1];
            getBetOdds();
        }

       //get the odds,isTriple,choosenSum1 and choosenSum2
        public void getBetOdds()
        {
            if (betInput>0 && betInput<5)
            {
                betOdds = 2;
            }
            else if(betInput>4 && betInput<11)
            {
                betOdds = 180;
                getChoosenDice();
            }
            else if (betInput > 10 && betInput < 17)
            {
                betOdds = 10;
                getChoosenDice();
            }
            else if (betInput==17)
            {
                betOdds = 30;
                tryTriple = true;
            }
            else if (betInput == 18)
            {
                betOdds = 60;
                choosenSum1 = 4;
                choosenSum2 = 17;
            }
            else if (betInput == 19)
            {
                betOdds = 30;
                choosenSum1 = 5;
                choosenSum2 = 16;
            }
            else if (betInput == 20)
            {
                betOdds = 18;
                choosenSum1 = 6;
                choosenSum2 = 15;
            }
            else if (betInput == 21)
            {
                betOdds = 12;
                choosenSum1 = 7;
                choosenSum2 = 14;
            }
            else if (betInput == 22)
            {
                betOdds = 8;
                choosenSum1 = 8;
                choosenSum2 = 13;
            }
            else if (betInput == 23)
            {
                betOdds = 7;
                choosenSum1 = 9;
                choosenSum2 = 12;
            }
            else if (betInput == 24)
            {
                betOdds = 6;
                choosenSum1 = 10;
                choosenSum2 = 11;
            }
            if (betInput==3) 
            {
                tryOdd = true;
            }
            if (betInput == 4)
            {
                tryEven = true;
            }

        }

        //gets the choosenDice in the case of Triples or Doubles
        public void getChoosenDice()
        {
            switch (betInput)
            {   
                case 5:
                case 11:
                {
                    choosenDice = 1;
                    break;
                }
                case 6:
                case 12:
                {
                    choosenDice = 2;
                    break;
                }
                case 7:
                case 13:
                {
                    choosenDice = 3;
                    break;
                }
                case 8:
                case 14:
                {
                    choosenDice = 4;
                    break;
                }
                case 9:
                case 15:
                {
                    choosenDice = 5;
                    break;
                }
                case 10:
                case 16:
                {
                    choosenDice = 6;
                    break;
                }

                
                default:
                    break;
            }

        }

        /*
        ~Bet()
        {

        }
         */

    }
}
