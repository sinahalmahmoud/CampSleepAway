using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;

namespace campsleepway.Models
{
    public class NextOfKin
    {
        public int NextOfKinId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
       
        public List<CamperNextOfKin> CamperNextOfKin { get; set; } = new List<CamperNextOfKin>();
        #region load
        public static void LoadNextOfKin()
        {
            using (var context = new DataContext())
            {
                var NextOfKin1 = new NextOfKin()
                {
                    Firstname = "Haytham",
                    Lastname = "Almahmoud",
                    Address = "Homs",
                    Telephone = "0788888888"

                };
                context.NextOfKins.Add(NextOfKin1);
                var NextOfKin2 = new NextOfKin()
                {
                    Firstname = "Reem",
                    Lastname = "Jannaz",
                    Address = "Munkedal\\centrumvägen",
                    Telephone = "0793333333"

                };
                context.NextOfKins.Add(NextOfKin2);
                var NextOfKin3 = new NextOfKin()
                {
                    Firstname = "Malek",
                    Lastname = "Sawsou",
                    Address = "Mukedal\\jhönasvägen",
                    Telephone = "0755555555"

                };
                context.NextOfKins.Add(NextOfKin3);
                var NextOfKin4 = new NextOfKin()
                {
                    Firstname = "Lana",
                    Lastname = "Alrasheed",
                    Address = "stokholm\\täbye",
                    Telephone = "072544444"

                };
                var NextOfKin5 = new NextOfKin()
                {
                    Firstname = "Bareaa",
                    Lastname = "GHojal",
                    Address = "Syria Homs",
                    Telephone = "0988997566"

                };
                var NextOfKin6 = new NextOfKin()
                {
                    Firstname = "Mohamed",
                    Lastname = "Sawsou",
                    Address = "Munkedal ",
                    Telephone = "072030025"

                };

        
                context.NextOfKins.AddRange(NextOfKin1, NextOfKin2, NextOfKin3, NextOfKin4,NextOfKin5 ,NextOfKin6 );
                context.SaveChanges();


            }

        }

        #endregion

        #region 
        public static void AddNextOfKin(string Firstname, string Lastname, string Address, string Telephone)
        {

            using (var context = new DataContext())
            {
                var NextOfKin = new NextOfKin()
                {
                    Firstname = Firstname,
                    Lastname = Lastname,
                    Address = Address,
                    Telephone = Telephone

                };
                context.NextOfKins.Add(NextOfKin);
                context.SaveChanges();
            }
        }

        #endregion

        #region delete
        public static void DeleteNextOfKinbyname(string NextOfKinname)
        {
            using (var context = new DataContext())
            {
                var l = context.NextOfKins.Where(p => p.Firstname == NextOfKinname)
                    .FirstOrDefault();
                if (l is NextOfKin)
                {
                    context.Remove(l);
                    context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }


        }

        public static void DeleteNextOfKinbyId(int id)
        {
            using (var context = new DataContext())
            {
                var l = context.NextOfKins.Where(p => p.NextOfKinId == id)
                    .FirstOrDefault();
                if (l is NextOfKin)
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
        public static void UppdateNextOfKin(int id, string newname, string newlast)
        {
            using (var context = new DataContext())
            {
                var l = context.NextOfKins.Where(p => p.NextOfKinId == id)
                    .FirstOrDefault();
                l.Firstname = newname;
                
                l.Lastname = newlast;

                context.SaveChanges();
            }
        }
        #endregion
    }
}
