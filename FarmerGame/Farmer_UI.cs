using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
//Purpose:  Assignment #3 Farmer Game View Class
//Date:2-24-17
//*******************************

namespace FarmerGame
{
    class Farmer_UI
    {
        Farmer_Logic logic;
        private int getSelection = 0;
        private int[] winnerLooser = new int[] { 0, 0 };
        private bool getSelectionBool = false;



        public Farmer_UI(Farmer_Logic logic)//constructor
        {
            this.logic = logic;
            PlayGame();
        }





        private void PlayGame()
        {
            int maxInput = 0;
            
            do
            {
              do
                {  maxInput = CreateScreen();//create user screen and get nort and southbank sizes
                
                    getSelectionBool = int.TryParse(Console.ReadLine(), out getSelection);// try parse user input
                } while (getSelectionBool == false || getSelection<=0 || getSelection >= maxInput);//end inner do loop

                logic.MoveItem(getSelection);//rearange north and southbank lists
                
            } while (logic.checkStateOfCharacters(logic.NorthBank, logic.SouthBank)[0] == 0 );//end outter do loop

            winnerLooser = logic.checkStateOfCharacters(logic.NorthBank, logic.SouthBank);

            switch (winnerLooser[0])
            {
                case 1:// user won
                    Console.Clear();
                    CreateScreen();//create user screen
                    Console.WriteLine("\nYou've Won!!! The Farmer thanks you.....");
                    
                    break;
                case 2:// user lost
                    Console.Clear();
                    CreateScreen();//create user screen
                    Console.Write("\n\nYou lost!!!");
                    if (winnerLooser[1] == 0)
                        Console.Write(" The Chicken ate the Grain. Then the Fox ate the Chicken.\n");
                    if (winnerLooser[1] == 1)
                        Console.Write(" The Fox ate the Chicken.\n");
                    else if (winnerLooser[1] == 2)
                        Console.Write(" The Chicken ate the Grain.\n");
                    break;
            }//end switch

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }//end playGame()

        private int CreateScreen()
        {
            int maxInput = 0;
            int indexKeeper = 1;


            Console.Clear();
            if (logic.NorthBank.Count > 0 && logic.NorthBank[0].Character.ToString().Equals("aFarmer") && winnerLooser[0] != 2)
            {
                maxInput = logic.NorthBank.Count;
                Console.WriteLine("Farmer is here.");
                Console.WriteLine("Select an item from the North Bank to move:");
                foreach (var getItem in logic.NorthBank)
                {
                    if (getItem.Character.ToString() != "aFarmer")
                    {
                        Console.WriteLine("{0}) {1}", indexKeeper, getItem.Character);

                        indexKeeper++;
                    }//end inner if
                }//end foreach

            }//end outter if
            else{
                foreach (var getItem in logic.NorthBank)
                {
                    if (getItem.Character.ToString() != "aFarmer")
                        Console.WriteLine("{0}", getItem.Character);
                    indexKeeper++;
                    //Console.WriteLine("{0}) {1},{2}", indexKeeper, getItem.Character, (Stock)getItem.CharacterValue);

                }//end foreach
            }//end else

            for (int i = indexKeeper; i < 6; i++)
            {
                Console.WriteLine();
            }//end for loop

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("**********************************************************************************************************");
            }//end for loop

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }//end for loop

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("**********************************************************************************************************");
            }//end for loop

            Console.ForegroundColor = ConsoleColor.White;

            if (logic.SouthBank.Count>0 && logic.SouthBank[0].Character.ToString().Equals("aFarmer") && winnerLooser[0] != 2)
            {
                maxInput = logic.SouthBank.Count;
                indexKeeper = 1;
                Console.WriteLine("Farmer is here.");
                Console.WriteLine("Select an item from the South Bank to move:");
                foreach (var getItem in logic.SouthBank)
                {
                    if (getItem.Character.ToString() != "aFarmer")
                    {
                        Console.WriteLine("{0}) {1}", indexKeeper, getItem.Character);
                        indexKeeper++;
                    }//end inner if

                }//end for each
            }//end outter if
            else
            {
                foreach (var getItem in logic.SouthBank)
                {
                    if (getItem.Character.ToString() != "aFarmer")
                        Console.WriteLine("{0}", getItem.Character);
                    

                }//end foreach
            }//end else

            Console.Write("\n\n\n> ");
            return maxInput;
        }//end CreateScreen()



    }//end class
}//end namespace

















            //Notes and experiments:
            /*Console.WriteLine("{0}", northBank.Count);
            Console.WriteLine("{0}", northBank.IndexOf(chicken));
            int test=0;
            foreach (var getItem in northBank)
            {
                Console.WriteLine("Item: {0},{1}", getItem.Character, (Stock)getItem.CharacterValue);
                test = test + getItem.CharacterValue;
            }
            Console.WriteLine(test);
            Console.WriteLine("Lastline {0}", (Stock) nothing.CharacterValue.GetHashCode());
            Console.WriteLine("Lastline {0}", (Stock)farmer.CharacterValue);
            Console.WriteLine("Lastline {0}", (Stock)farmer.Character);*/
