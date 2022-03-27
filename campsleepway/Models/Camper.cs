using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;

namespace campsleepway.Models
{
    public class Camper
    {
        public int CamperId { get; set; }
        public string Firstname { get; set; }
        public string Middelname { get; set; }
        public string Lastnamme { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        

        public List<Historik> Historiks { get; set; } = new List<Historik>();
        public List<CamperNextOfKin> CamperNextOfKin { get; set; } = new List<CamperNextOfKin>();
        

        #region LoadCamper
        public static void LoadCampers()
        {
            using (var context = new DataContext())
            {



                var Camper1 = new Camper()
                {
                    Firstname = "Ghaleb",
                    Middelname = "Haytham",
                    Lastnamme = "Mahmood",
                    Address = "Munkedal",
                    Age = 7,
                    

                };
                
                var Camper2 = new Camper()
                {
                    Firstname = "Lara",
                    Middelname = "Mohamed",
                    Lastnamme = "Sawsou",
                    Address = "Munkedal",
                    Age = 4,
                       
                };
                
                var Camper3 = new Camper()
                {
                    Firstname = "Rakan",
                    Middelname = "Malek",
                    Lastnamme = "Sawsou",
                    Address = "Munkedal",
                    Age = 18,
                    
                };
                var Camper4 = new Camper()
                {
                    Firstname = "Omar",
                    Middelname = "Malek",
                    Lastnamme = "Sawsou",
                    Address = "Mukedal",
                    Age = 12,
                    

                };
                var Camper5 = new Camper()
                {
                    Firstname = "Remi",
                    Middelname = "Lana",
                    Lastnamme = "Rasheed",
                    Address = "stokholm",
                    Age = 12,
                    //NextOfKins = new List<NextOfKin>
                    //    { context .NextOfKins.Where(p => p.Firstname == "Lana").FirstOrDefault() },

                    //  nextOfKins = new List<NextOfKin>(16),

                };
                var Camper6 = new Camper()
                {
                    Firstname = "Rayan",
                    Middelname = "Lana",
                    Lastnamme = "Rasheed",
                    Address = "stokholm",
                    Age = 6,
                    // nextOfKins = new List<NextOfKin>(16),
                    //    NextOfKins = new List<NextOfKin>
                    //        { context .NextOfKins.Where(p => p.Firstname == "Lana").FirstOrDefault() }
                };
                var Camper7 = new Camper()
                {
                    Firstname = "Ameer",
                    Middelname = "Mohamed",
                    Lastnamme = "Sawsou",
                    Address = "Munkedal",
                    Age = 10,
                    //NextOfKins = new List<NextOfKin>
                    //    { context .NextOfKins.Where(p => p.Firstname == "Reem").FirstOrDefault() }


                };
                var Camper8 = new Camper()
                {
                    Firstname = "Nart",
                    Middelname = "Maged",
                    Lastnamme = "Alaa",
                    Address = "Oslo",
                    Age = 11,

                };
                var Camper9 = new Camper()
                {
                    Firstname = "Taya",
                    Middelname = "Mafa",
                    Lastnamme = "Maher",
                    Address = "newyork",
                    Age = 8,

                };
                var Camper10 = new Camper()
                {
                    Firstname = "Anzor",
                    Middelname = "Mafa",
                    Lastnamme = "Maher",
                    Address = "newyork",
                    Age = 6,

                };
                var Camper11 = new Camper()
                {
                    Firstname = "Aslan",
                    Middelname = "Haytham",
                    Lastnamme = "Almahmoud",
                    Address = "Munkedal",
                    Age = 5,

                };
                var Camper12 = new Camper()
                {
                    Firstname = "Baslan",
                    Middelname = "Haytham",
                    Lastnamme = "Almahmoud",
                    Address = "Munkedal",
                    Age = 2,

                };
                var Camper13 = new Camper()
                {
                    Firstname = "Adam",
                    Middelname = "Mahmood",
                    Lastnamme = "Asran",
                    Address = "usa",
                    Age = 14,

                };
                var Camper14 = new Camper()
                {
                    Firstname = "Dina",
                    Middelname = "Mahmood",
                    Lastnamme = "Asran",
                    Address = "usa",
                    Age = 12,

                };
                var Camper15 = new Camper()
                {
                    Firstname = "Merna",
                    Middelname = "Majed",
                    Lastnamme = "Alaa alden",
                    Address = "Norja",
                    Age = 13,

                };
                var Camper16 = new Camper()
                {
                    Firstname = "nars",
                    Middelname = "Majed",
                    Lastnamme = "Alaa alden",
                    Address = "norja",
                    Age = 8,


                };
                var Camper17 = new Camper()
                {
                    Firstname = "Lemar",
                    Middelname = "Aeman",
                    Lastnamme = "Rajab",
                    Address = "Homs",
                    Age = 11,

                };
                var Camper18 = new Camper()
                {
                    Firstname = "Wael",
                    Middelname = "Amen",
                    Lastnamme = "Hattam",
                    Address = "damascuss",
                    Age = 9,

                };




                context.Campers.AddRange(Camper1, Camper2, Camper3, Camper4, Camper5, Camper6, Camper7, Camper8, Camper9, Camper10, Camper11, Camper12, Camper13, Camper14, Camper15, Camper16, Camper17, Camper18);
                context.SaveChanges();
            }
        }

        #endregion

        #region Add
        public static void AddCamper(string Firstname, string Middelname,string Lastnamme,string Address,int Age)
        {

            using (var context = new DataContext())
            {
                var camper = new Camper()
                {
                    Firstname = Firstname,
                    Middelname = Middelname,
                    Lastnamme= Lastnamme,
                    Address= Address,
                    Age= Age
                };
                context.Campers .Add(camper);
                context.SaveChanges();
            }
        }

        #endregion

        #region Delete
        public static void DeleteCamperbyname(string campername)
        {
            using (var context = new DataContext())
            {
                var l = context.Campers.Where(p => p.Firstname == campername)
                    .FirstOrDefault();
                if (l is Camper) { context.Remove(l); 
                    context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }


        }
        

       
        public static void DeleteCamperbyId(int ID)
        {
            using (var context = new DataContext())
            {
                var l = context.Campers.Where(p => p.CamperId == ID)
                    .FirstOrDefault();
                if (l is Camper)
                {
                    context.Remove(l);
                    context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }


        }

        #endregion

        #region update
        public static void UppdateCampername(int id, string newname,string newlast)
        {
            using (var context = new DataContext())
            {
                var l = context.Campers.Where(p => p.CamperId == id)
                    .FirstOrDefault();
                l.Firstname = newname;
                l.Lastnamme = newlast;

                context.SaveChanges();
            }
        }

        #endregion 
    }
}
    
