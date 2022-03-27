using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;
using campsleepway.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace campsleepway.Models
{
    public class load
    {
        public static void loading()
        {
            using (var context = new DataContext())
            {
                var query = from c in context.Cabins
                            select new { id = c.CabinId };
                if (query.Count() == 0)

                {
                    Cabin.loadCabin();
                    Console.WriteLine("Cabins Loaded");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();

                    Counselor.LoadCounselor();
                    Console.WriteLine("Counsler Loaded");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();


                    NextOfKin.LoadNextOfKin();
                    Console.WriteLine("Nextofkin Loaded");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();

                    Camper.LoadCampers();
                    Console.WriteLine("All Campers Loaded");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();

                    Historik.LoadHistorik();
                    CamperNextOfKin.AddCamperNextOfKin();
                    Console.WriteLine("Your Database is ready now ");
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                }
                else Console.WriteLine("You have data already");
            }
        }
    }
}
