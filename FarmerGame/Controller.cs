using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGame
{
    class Controller
    {
        Farmer_Logic logic;
        Farmer_UI farmer_ui;
        String loopController = "Y";




        public Controller()
        {
            Begin();
        }

        private void Begin()
        {
            do
            {
                logic = new Farmer_Logic();
                farmer_ui = new Farmer_UI(logic);
                Console.Clear();
                Console.Write("\n\nWould you like to play again? Y:N\n> ");
                loopController = Console.ReadLine().ToUpper();

            } while (loopController != "N");
        }
    }
}
