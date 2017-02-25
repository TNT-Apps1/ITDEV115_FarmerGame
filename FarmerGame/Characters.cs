using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
//Purpose:  Assignment #3 Build characters for game from enum constant
//Date:2-24-17
//*******************************
namespace FarmerGame
{
    public enum Stock //a constant set of characters and their respective values
    {
        Nothing = 0,
        aFarmer = 1,
        Chicken = 50,
        Fox = 100,
        Grain= 200
    }

    class Characters : IComparable<Characters>
    {

        private Stock character;
        private int characterVaule;

        public int CharacterValue
        {
            get { return characterVaule; }
            set { characterVaule = value; }
        }


        public Stock Character
        {
            get { return character; }
            
        }

        public Characters(Stock stock)// constructer to set character to instance w/ their constant value from enum
        {
            character = stock;
            CharacterValue = (int)character;
        }

        public int CompareTo(Characters other)//compareing method for sorting characters by string value
        {
            return this.Character.ToString().CompareTo(other.Character.ToString());
        }
    }
}
