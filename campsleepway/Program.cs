using System;
using System.Linq;
using campsleepway.connect;
using campsleepway.Models;



namespace campsleepway
{
    class Program
    {
        private static readonly DataContext contextprogram = new DataContext();
        static void Main(string[] args)
        {

            Console.WriteLine("          WELCOM TO CAMPSLEEPWAY          ");
            Console.WriteLine("      Please wait loading Database.... ");
            load.loading();
            menu.mainmenu();

        }
        }
    }


