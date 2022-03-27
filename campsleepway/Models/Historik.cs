using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;

namespace campsleepway.Models
{
    public class Historik
    {
        public int HistorikId { get; set; }

        public int CabinId { get; set; }
        [ForeignKey("CabinId")]
        public Cabin Cabin { get; set; }


        public int CounselorId { get; set; }
        [ForeignKey("CounselorId")]
        public Counselor Counselor { get; set; }

        public int CamperId { get; set; }
        [ForeignKey("CamperId")]
        public Camper Camper { get; set; }
        public DateTime Datestart { get; set; }
        public DateTime Datestop { get; set; }

        public string availablecounsler { get; set; }
        #region AddHistorik
        public static void addHistorikout(int CabinId, int CamperId, int CounselorId, DateTime Datestart, DateTime Datestop, string av)
        {
            using (var context = new DataContext())
            {
                var historik = new Historik()
                {
                    CabinId = CabinId,
                    CamperId = CamperId,
                    CounselorId = CounselorId,
                    Datestart = Datestart,
                    Datestop = Datestop,
                    availablecounsler = av


                };
                
                    context.Add(historik);
                    context.SaveChanges();
                
                }
            }

        
        #endregion

        #region loadHistorik
        public static void LoadHistorik()
        {

            using (var context = new DataContext())
            {
                var Historik1 = new Historik()
                {
                    CabinId = 1,

                    CamperId = 1,
                    CounselorId = 1,

                    Datestart = new DateTime(2023, 01, 01),
                    Datestop = new DateTime(2023, 01, 06),
                    availablecounsler = "yes"

                };
                var Historik11 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 2,
                    CounselorId = 1,
                    Datestart = new DateTime(2023, 01, 01),
                    Datestop = new DateTime(2023, 01, 06),
                    availablecounsler = "yes"

                };
                var Historik13 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 3,
                    CounselorId = 1,
                    Datestart = new DateTime(2023, 01, 01),
                    Datestop = new DateTime(2023, 01, 06),
                    availablecounsler = "yes"

                };
                var Historik14 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 4,
                    CounselorId = 1,
                    Datestart = new DateTime(2023, 01, 01),
                    Datestop = new DateTime(2023, 01, 06),
                    availablecounsler = "yes"
                };

                var Historik2 = new Historik()
                {
                    CabinId = 2,
                    CamperId = 4,
                    CounselorId = 2,
                    Datestart = new DateTime(2023, 02, 01),
                    Datestop = new DateTime(2023, 02, 06),
                    availablecounsler = "yes"


                };
                var Historik21 = new Historik()
                {
                    CabinId = 2,
                    CamperId = 5,
                    CounselorId = 2,
                    Datestart = new DateTime(2023, 02, 01),
                    Datestop = new DateTime(2023, 02, 06),
                    availablecounsler = "yes"


                };

                //var Historik22 = new Historik()
                //{
                //    CabinId = 2,
                //    CamperId = 1,
                //    CounselorId = 2,
                //    Datestart = new DateTime(2020, 02, 01),
                //    Datestop = new DateTime(2020, 02, 06),
                //    availablecounsler = "yes"


                //};
                //var Historik23 = new Historik()
                //{
                //    CabinId = 2,
                //    CamperId = 11,
                //    CounselorId = 2,
                //    Datestart = new DateTime(2020, 02, 01),
                //    Datestop = new DateTime(2020, 02, 06),
                //    availablecounsler = "yes"


                //};


                var Historik3 = new Historik()
                {
                    CabinId = 3,
                    CamperId = 1,
                    CounselorId = 3,
                    Datestart = new DateTime(2023, 03, 01),
                    Datestop = new DateTime(2023, 03, 06),
                    availablecounsler = "yes"


                };
                //var Historik31 = new Historik()
                //{
                //    CabinId = 3,
                //    CamperId = 11,
                //    CounselorId = 3,
                //    Datestart = new DateTime(2020, 03, 01),
                //    Datestop = new DateTime(2020, 03, 06),
                //    availablecounsler = "yes"


                //};
                //var Historik32 = new Historik()
                //{
                //    CabinId = 3,
                //    CamperId = 15,
                //    CounselorId = 3,
                //    Datestart = new DateTime(2020, 03, 01),
                //    Datestop = new DateTime(2020, 03, 06),
                //    availablecounsler = "yes"


                //};

                //var Historik33 = new Historik()
                //{
                //    CabinId = 3,
                //    CamperId = 10,
                //    CounselorId = 3,
                //    Datestart = new DateTime(2020, 03, 01),
                //    Datestop = new DateTime(2020, 03, 06),
                //    availablecounsler = "yes"


                //};

                var Historik4 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 11,
                    CounselorId = 4,
                    Datestart = new DateTime(2023, 03, 01),
                    Datestop = new DateTime(2023, 03, 06),
                    availablecounsler = "no"

                };

                var Historik41 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 12,
                    CounselorId = 4,
                    Datestart = new DateTime(2023, 03, 01),
                    Datestop = new DateTime(2023, 03, 06),
                    availablecounsler = "no"


                };

                var Historik42 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 13,
                    CounselorId = 4,
                    Datestart = new DateTime(2023, 03, 01),
                    Datestop = new DateTime(2023, 03, 06),
                    availablecounsler = "no"


                };

                var Historik43 = new Historik()
                {
                    CabinId = 1,
                    CamperId = 14,
                    CounselorId = 4,
                    Datestart = new DateTime(2023, 03, 01),
                    Datestop = new DateTime(2023, 03, 06),
                    availablecounsler = "no"


                };


                context.AddRange(Historik1, Historik11, Historik13, Historik14,
                    Historik2, Historik21, /*Historik22, Historik23*//*,*/
                    Historik3, /*Historik31, Historik32, Historik33,*/
                    Historik4, Historik41, Historik42, Historik42);

                context.SaveChanges();


            }
        }
        #endregion
        public static void uodatecounselor()
        {

            Console.WriteLine("you can choice on of this record to be updated  ");
            methods.AllHIstorik();
            Console.WriteLine("please enter the id for the record you want to change counselor for it ");
            int userid = Convert.ToInt32(Console.ReadLine());
            using (var context = new DataContext())

            {
                var query = from H in context.Historiks
                            where H.HistorikId == userid

                            select new
                            {
                                thcabinid = H.CabinId,
                                thecounselorid = H.CounselorId,
                                start = H.Datestart
                            };

                foreach (var item in query)
                {
                    Console.WriteLine("the cabin id is: " + item.thcabinid +
                       "the counselor id is: " + item.thecounselorid +
                       "the start date : " + item.start);

                }
            }
            Console.WriteLine("please enter the start date for this cabin");
            DateTime userdate = Convert.ToDateTime(Console.ReadLine());
            DateTime userdateout = userdate.AddDays(5);
            Console.WriteLine("choose the new counselor you want\n");
            int usercounselor = int.Parse(Console.ReadLine());
            if (methods.AvailableCounsler(userid, userdate) == true) 
            Console.WriteLine("this counsoler is available");


            updatehistorik(userid, userdate/*, userdateout*/, usercounselor);


        }
        static void updatehistorik(int id, DateTime c/*,DateTime  d*/, int idnew)
        {
            using (var context = new DataContext())

            {


                foreach (var l in context.Historiks.Where(p => p.CabinId == id).Where(p => p.Datestart == c)/*.Where(p => p.Datestop == d)*/
                       .ToList())
                {
                    l.CounselorId = idnew;
                    l.availablecounsler = "yes";
                }



                context.SaveChanges();
                Console.WriteLine("Done");

            }
        }

        public static void deletecounselor()
        {

            Console.WriteLine("you can choice on of this record to delete his counselor  ");
            methods.AllHIstorik();
            Console.WriteLine("please enter the id for the record you want to change counselor for it ");
            int userid = Convert.ToInt32(Console.ReadLine());
            using (var context = new DataContext())

            {
                //var query = from H in context.Historiks
                //            where H.HistorikId == userid

                //            select new
                //            {
                //                thcabinid = H.CabinId,
                //                thecounselorid = H.CounselorId,
                //                start = H.Datestart
                //            };

                //foreach (var item in query)
                //{
                //    Console.WriteLine("the cabin id is: " + item.thcabinid +
                //       "the counselor id is: " + item.thecounselorid +
                //       "the start date : " + item.start);

                //}

                Console.WriteLine("please enter the start date for this cabin");
                DateTime userdate = Convert.ToDateTime(Console.ReadLine());
                DateTime userdateout = userdate.AddDays(5);
                Console.WriteLine("please enter the id counselor you want\n");
                int usercounselor = int.Parse(Console.ReadLine());
                if (methods.AvailableCounsler(userid, userdate) == false)
                {



                    foreach (var l in context.Historiks.Where(p => p.CabinId == userid).Where(p => p.Datestart == userdate)/*.Where(p => p.Datestop == d)*/
                                .ToList())
                    {

                        l.availablecounsler = "no";
                    }
                context.SaveChanges();

                }
                else { Console.WriteLine("This Counselor is not active already"); }


            }
        }
    }
}
