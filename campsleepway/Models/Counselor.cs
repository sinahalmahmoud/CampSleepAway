using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;

namespace campsleepway.Models
{
    public class Counselor
    {
        public int CounselorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Historik > CamperHistoriks { get; set; } = new List<Historik >();



        #region load Counselor
        public static void LoadCounselor()
        {
            using (var context = new DataContext())
            {
                var Counselor1 = new Counselor()
                {
                    Firstname ="Sinah",
                    Lastname ="Almahmoud",
                    Phone ="07777777",
                    Email="sinah.almahmoud@hotmail.com"

                };
                var Counselor2 = new Counselor()
                {
                    Firstname = "Firas",
                    Lastname = "Sawsou",
                    Phone = "0788888",
                    Email = "firas.sawsou@hotmail.com"

                };
                var Counselor3 = new Counselor()
                {
                    Firstname = "Taya",
                    Lastname = "Sawsou",
                    Phone = "0766666",
                    Email = "taya.sawsou@hotmail.com"

                };
                var Counselor4 = new Counselor()
                {
                    Firstname = "Maram",
                    Lastname = "zen",
                    Phone = "076665456",
                    Email = "maram.zen@hotmail.com"

                };
                context.Counselors.AddRange(Counselor1, Counselor2 ,Counselor3,Counselor4);
                context.SaveChanges();
            }
        }

        #endregion

        #region Add
        public static void AddCounselro(string Firstname, string Lastname, string Phone, string Email)
        {

            using (var context = new DataContext())
            {
                var Counselro = new Counselor()
                {
                    Firstname = Firstname,
                    Lastname = Lastname,
                    Phone = Phone,
                    Email = Email
                   
                };
                context.Counselors.Add(Counselro);
                context.SaveChanges();
            }
        }

        #endregion

        #region Delete
        public static void DeleteCounselorbyname(string counselorname)
        {
            using (var context = new DataContext())
            {
                var l = context.Counselors.Where(p => p.Firstname == counselorname)
                    .FirstOrDefault();
                if (l is Counselor)
                {
                    context.Remove(l);
                    context.SaveChanges();
                    Console.WriteLine("done!");
                }
                else Console.WriteLine(" sorry we dont have this choice");


            }


        }

        public static void DeleteCounselorbyId(int id)
        {
            using (var context = new DataContext())
            {
                var l = context.Counselors.Where(p => p.CounselorId == id)
                    .FirstOrDefault();
                if (l is Counselor)
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
        public static void UppdateCounselorrname(int id, string newname, string newlast)
        {
            using (var context = new DataContext())
            {
                var l = context.Counselors.Where(p => p.CounselorId == id)
                    .FirstOrDefault();
                l.Firstname = newname;
                l.Lastname = newlast;

                context.SaveChanges();
            }
        }
        #endregion
    }
}
