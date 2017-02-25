using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
//Purpose:  Assignment #3 Farmer Game Logic
//Date:2-24-17
//*******************************

namespace FarmerGame
{
    class Farmer_Logic
    {
        //create instance of all characters
        Characters nothing = new Characters(Stock.Nothing);
        Characters farmer = new Characters(Stock.aFarmer);
        Characters chicken = new Characters(Stock.Chicken);
        Characters fox = new Characters(Stock.Fox);
        Characters grain = new Characters(Stock.Grain);


        //create north and south bank lists
        List<Characters> northBank = new List<Characters>();
        List<Characters> southBank = new List<Characters>();


        //properties (getters)
        public List<Characters> NorthBank { get{ return northBank; } }
        public List<Characters> SouthBank { get { return southBank; } }


        //constructor
        public Farmer_Logic()
        {
            northBank.Add(nothing);
            northBank.Add(farmer);
            northBank.Add(chicken);
            northBank.Add(fox);
            northBank.Add(grain);
            southBank.Clear();
            northBank.Sort();

        }



        //checks sum of values for each list and returns flag value to farmer_ui
        public int[] checkStateOfCharacters(List<Characters> northBank, List<Characters> southBank)
        {
            int[] returnedValue = new int[2];
            int northValue = 0;
            int southValue = 0;

            
            foreach (var getItem in northBank)
            {
                northValue = northValue + getItem.CharacterValue;
            }

            foreach (var getItem in southBank)
            {
                southValue = southValue + getItem.CharacterValue;
            }

            if((northValue == 300 || northValue == 301 || northValue == 351 || northValue== 251 || northValue == 51 || northValue == 151) || (southValue == 300 || southValue == 200 || southValue == 301 ||  southValue == 151 || southValue == 251 || southValue == 100 || southValue == 50))
            {
                returnedValue[0] = 0;//set switch flag
                return returnedValue;//keep Playing
            }else if(southValue==351)
            {
                returnedValue[0] = 1;//set switch flag
                return returnedValue;//winner
            }
            else
            {
                returnedValue[0] = 2;//set switch flag
                if (northValue == 350 || southValue == 350)
                {
                    returnedValue[1] = 0;
                }else if (northValue == 150 || southValue == 150)
                {
                    returnedValue[1] = 1;
                }else
                {
                    returnedValue[1] = 2;
                }
                
                
                return returnedValue;//looser
            }

        }


        //rearabge nort and southbank lists to user input values
        internal void MoveItem(int getSlection)
        {
            if(NorthBank[0].Character.ToString().Equals("aFarmer"))
            {
                southBank.Add(northBank[getSlection]);
                southBank.Add(farmer);
                if (getSlection < northBank.Count - 1)
                    southBank.Add(northBank.Last());
                northBank.Remove(northBank[getSlection]);
                northBank.Remove(farmer);
                if(northBank.Contains(nothing))
                    northBank.Remove(nothing);
                northBank.Sort();
                southBank.Sort();

            }
            else
            {
                
                northBank.Add(southBank[getSlection]);
                northBank.Add(farmer);
                if (getSlection < southBank.Count - 1)
                    northBank.Add(southBank.Last());
                southBank.Remove(southBank[getSlection]);
                southBank.Remove(farmer);
                if (southBank.Contains(nothing))
                    southBank.Remove(nothing);
                southBank.Sort();
                northBank.Sort();
            }
        }
    }
}
