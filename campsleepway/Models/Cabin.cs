using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;

namespace campsleepway.Models
{
    public class Cabin
    {
        public int CabinId { get; set; }
        public string Cabiname { get; set; }
        public int Cabacity { get; set; }
        public List<Historik> Historiks { get; set; } = new List<Historik>();
        #region Load cabin
        public static void loadCabin()
        {
            using (var context = new DataContext())
            {
                var cabin1 = new Cabin()
                {
                    Cabiname = "green",
                    Cabacity = 4

                };
                var cabin2 = new Cabin()
                {
                    Cabiname = "red",
                    Cabacity = 4

                };
                var cabin3 = new Cabin()
                {
                    Cabiname = "blue",
                    Cabacity = 4

                };
                context.Cabins.AddRange(cabin1, cabin2, cabin3);
                context.SaveChanges();
            }
        }
        #endregion

        #region AddCabin
        public static void AddCabin(string Cabiname, int Cabacity)
        {

            using (var context = new DataContext())
            {
                var cabin = new Cabin()
                {
                    Cabiname = Cabiname,
                    Cabacity = Cabacity
                };
                context.Cabins.Add(cabin);
                context.SaveChanges();
            }
        }
        #endregion

        #region Delete
        public static void DeleteCabinBYname(string Cabiname)
        {
            using (var context = new DataContext())
            {
                var l = context.Cabins.Where(p => p.Cabiname == Cabiname)
                    .FirstOrDefault();
                if (l is Cabin)
                {
                    context.Remove(l); context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }

        }
        public static void DeleteCabinBYid(int Cabid)
        {
            using (var context = new DataContext())
            {
                var l = context.Cabins.Where(p => p.CabinId == Cabid)
                    .FirstOrDefault();
                if (l is Cabin)
                {
                    context.Remove(l); context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }
        }
        #endregion

        #region update
        public static void UppdateCAbiname(int id ,string newname)
        {
            using (var context = new DataContext())
            {
                var l = context.Cabins.Where(p => p.CabinId == id)
                    .FirstOrDefault();
                l.Cabiname = newname;
               
                context .SaveChanges();
            }
        }
        #endregion

    }
}
