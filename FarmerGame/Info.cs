using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************
//Programmer:  Grant Thompson
// ITDEV115 SPRING 2017 TUESDAY EVENING
//Purpose:  Assignment #3 Farmer Game Information
//Date:2-24-17
//*******************************
namespace FarmerGame
{
    class Info
    {


        public Info()
        {
            DisplayInfo();
        }



        private void DisplayInfo()
        {
            Console.WriteLine("\n\nStudent:\tGrant Thompson");
            Console.WriteLine("Date:\t\t2-25-17");
            Console.WriteLine("Course:\t\t2017 Spring - ITDEV 115");
            Console.WriteLine("Assignment:\tFarmer Game");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Welcome to the Farmer Game. Your goal is to get all 3 items (Chicken, Fox and Grain) across the river");
            Console.WriteLine("to the South Bank so the Farmer can get them all to market. The catch is you can only move one item at");
            Console.WriteLine("a time (or choose nothing to move). And, you can't leave the Chicken unattended with the Grain or the Fox");
            Console.WriteLine("with the Chicken. They'll get hungry and the Chicken will eat all the Grain if left alone or the Fox will");
            Console.WriteLine("eat the Chicken.");
            Console.WriteLine("\n\nPress any key to begin.");
            Console.ReadKey();
        }
    }
}
