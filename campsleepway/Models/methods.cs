using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;
using Microsoft.EntityFrameworkCore;

namespace campsleepway.Models
{
    public class methods
    {
        public static bool AvailableCounsler(int id, DateTime start)
        {
            using (var context = new DataContext())
            {
                var l = context.Historiks.Where(p => p.CounselorId == id).Where(p => p.Datestart == start).Where(p => p.availablecounsler == "yes").Count();

                if (l > 0) return false;
                else return true;

            }

        }
        public static void AllCabin()
        {
            using (var context = new DataContext())
            {
                var query = from C in context.Cabins
                            select new { Thename = C.Cabiname };
                foreach (var item in query)
                {
                    Console.WriteLine("The Cabin NAme IS :" + item.Thename);
                }
            }
        }

        public static void AllCamper()
        {
            using (var contex = new DataContext())
            {
                var query = from CA in contex.Campers
                            select new
                            {
                                theid = CA.CamperId,
                                thenamef = CA.Firstname,
                                thenamel = CA.Lastnamme,
                                theage = CA.Age,
                                theaddress = CA.Address
                            };
                foreach (var item in query)
                {
                    Console.WriteLine(" " + item.theid + "  "
                        + item.thenamef + " " + item.thenamel + "  "
                        + item.theage + "  " + item.theaddress);
                }
            }
        }

        public static void Allnextofkin()
        {
            using (var context = new DataContext())
            {
                var query = from NE in context.NextOfKins
                            select new
                            {
                                theid = NE.NextOfKinId,
                                thenamef = NE.Firstname,
                                thenamel = NE.Lastname,
                                thetelephone = NE.Telephone,
                                theaddress = NE.Address
                            };
                foreach (var item in query)
                {
                    Console.WriteLine(" " + item.theid + "  "
                        + item.thenamef + " " + item.thenamel + "  "
                        + item.thetelephone + "  " + item.theaddress);
                }
            }
        }

        public static void AllCounselor()
        {
            using (var context = new DataContext())
            {
                var query = from CN in context.Counselors
                            select new
                            {
                                theid = CN.CounselorId,
                                thenamef = CN.Firstname,
                                thenamel = CN.Lastname,
                                thetelephone = CN.Phone,
                                theemail = CN.Email
                            };
                foreach (var item in query)
                {
                    Console.WriteLine(" " + item.theid + "  "
                        + item.thenamef + " " + item.thenamel + "  "
                        + item.thetelephone + "  " + item.theemail);
                }
            }
        }



        public static void AllHIstorik()
        {
            using (var context = new DataContext())
            {
                var query = from H in context.Historiks
                            join C in context.Campers on H.CamperId equals C.CamperId
                            join CA in context.Cabins on H.CabinId equals CA.CabinId
                            join CN in context.Counselors on H.CounselorId equals CN.CounselorId
                            select new
                            {
                                theid = H.HistorikId,
                                theCamper = C.Firstname,
                                theCabin = CA.Cabiname,
                                theCabinId= CA.CabinId,
                                theCounselor = CN.Firstname,
                                start = H.Datestart,
                                stop = H.Datestop,
                                available =H.availablecounsler 

                            };
                foreach (var item in query)
                {
                    Console.WriteLine("RecordId: " + item.theid + "  Camper: "
                        + item.theCamper + "  Cabin: " + item.theCabin + "  the cabin Id " + item .theCabinId + "  Counselor: "
                        + item.theCounselor + "  Start: " + item.start + " End: " + item.stop+ "  " + item .available );
                }
            }
        }


        

        public static void getcamperbycabin(string ccabinn)
        {
            using (var context = new DataContext())
            {


                var query = from H in context.Historiks
                            join C in context.Campers on H.CamperId equals C.CamperId
                            join B in context.Cabins on H.CabinId equals B.CabinId
                            join A in context.Counselors on H.CounselorId equals A.CounselorId
                            where B.Cabiname == ccabinn

                            select new
                            {
                                thecabin = B.Cabiname,
                                camperName = C.Firstname,
                                camperlname = C.Lastnamme,

                                couname = A.Firstname,
                                start = H.Datestart,
                                stop = H.Datestop,
                                availabel = H.availablecounsler
                            };
                if (query.Count() == 0)
                {
                    Console.WriteLine("Sorry this cabin didnt have campers to show");
                }

                else 
                if (query.Count() > 0)

                {   foreach (var item in query)




                        if (item.availabel == "yes")

                        {
                            Console.WriteLine("the camper name is  " + item.camperName +
                                "The First Day is: " + item.start +
                                "The Last day is " + item.stop
                               );

                        }
                        else if (item.availabel == "no")
                        {
                            Console.WriteLine("___________________________________\n");
                            Console.WriteLine("The counselor " + item.couname +
                                " in this Cabin is busy between " + item.start + "  " + item.stop);
                        }
                    


                }

            }
        }
        public static void getcamperbycouclor(string counselor)
        {
            using (var context = new DataContext())
            {

                var query = from H in context.Historiks
                            join C in context.Campers on H.CamperId equals C.CamperId
                            join A in context.Counselors on H.CounselorId equals A.CounselorId
                            where A.Firstname == counselor
                           

                            select new
                            {
                                thecounslor = A.Firstname,
                                camperName = C.Firstname,
                                start = H.Datestart,
                                stop = H.Datestop,
                                availabel = H.availablecounsler
                            };


                if (query.Count() == 0)
                {
                    Console.WriteLine("Sorry this counselor is not with any campers or cabin");
                }

                else
               if (query.Count() != 0)

                {  foreach (var item in query)
                    {
                        if (item.availabel == "yes")

                        {
                            Console.WriteLine("the counselor is available");


                            Console.WriteLine("the camper name is  " + item.camperName + " " + "the start time is  " + item.start
                                + " " + "the stop time is  " + item.stop);

                        }
                        else
                        //if (item.availabel == "no")
                        {

                            Console.WriteLine("the counselor is not availabil so the cabin is not available to");

                        }
                    }

                }

            }
        }

        #region campernextofkin
        public static void campernextofkin()
        {
            using (var context = new DataContext())
            {
                var query = from CN in context.CamperNextOfKin
                            join N in context.NextOfKins on CN.NextOfKinId equals N.NextOfKinId
                            join C in context.Campers on CN.CamperId equals C.CamperId
                            join H in context.Historiks on C.CamperId equals H.CamperId
                            join CA in context.Cabins on H.CabinId equals CA.CabinId
                            //where CN.CamperNAme == S

                            orderby H.CabinId
                            select new
                            {
                                thecamper = C.Firstname,
                                thelast=C.Lastnamme,
                                campernext = N.Firstname,
                                Cabinn = CA.Cabiname
                            };
                if (query.Count() != 0)
                {
                    foreach (var item in query)
                    {
                        Console.WriteLine("Camper First Name is " + item.thecamper +" "+ "Camper Last Name is " + item.thelast+
                            " "+ "Nextofkin is " + item.campernext+ " "+ "Cabin id is " + item.Cabinn);
                        
                    }
                }
                else Console.WriteLine("This Camper does not have NextOfKin  ");

            }






        }
        #endregion 
        public static void addcabincamper()
        {
            Console.WriteLine("enter the id of the cabin you want to add camper to it ");
            int ucabin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the start date ");
            DateTime ubegin = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter the leave date ");
            DateTime uleave = Convert.ToDateTime(Console.ReadLine());
            using (var context = new DataContext())
            {
                var query = from H in context.Historiks
                            where H.CabinId == ucabin
                            where H.Datestart == ubegin
                            where H.Datestop == uleave
                            select new
                            {
                                theid = H.HistorikId,
                                thecou=H.CounselorId,

                            };


                if (query.Count() == 0)
                {
                    Console.WriteLine("the cabin is available");
                    Console.WriteLine("please enter the counselor id");
                    int i = Convert.ToInt32(Console.ReadLine());
                    int count = query.Count();

                    if (AvailableCounsler (i, ubegin) == true)

                    {

                        do
                        {

                            Console.WriteLine("you kan enter camper");

                            Console.WriteLine("please enter the camper id ");
                            int cidu2 = Convert.ToInt32(Console.ReadLine());
                            if (iscamperavailabel(cidu2, ubegin) == true)
                            {
                                Historik.addHistorikout(ucabin, cidu2, i, ubegin, uleave,"yes");
                                count++;

                            } 
                           else Console.WriteLine("this camper is not available");
                        }
                        while (count  < 4 && count  > 0);
                        
                        Console.WriteLine("the cabin now is full");

                    }
                    else 
                    Console.WriteLine("Sorry this Couselor is not available try again");
                   
                }

                else if (query.Count() < 4 && query.Count() > 0 &&  context.Historiks.FirstOrDefault(x => x.CabinId == ucabin
                     && x.Datestart == ubegin
                     && x.Datestop == uleave).availablecounsler=="yes")
                {
                    
                    int platser= 4 - query.Count();
                   
                    int i = context.Historiks.FirstOrDefault(x => x.CabinId == ucabin
                    && x.Datestart == ubegin
                    && x.Datestop == uleave).CounselorId;
                    Console.WriteLine("the cabin is available and have  " + platser + "  platser with counselro ID :"+ i);
                    int count1 = query.Count();

                    //if (iscounseloravailable(i, ubegin) == false)

                    //{
                        do
                        {

                            Console.WriteLine("you kan enter camper");
                            Console.WriteLine("please enter the next camper id ");
                            int cidu2 = Convert.ToInt32(Console.ReadLine());
                            if (iscamperavailabel(cidu2, ubegin) == true)
                            {
                                Historik.addHistorikout(ucabin, cidu2, i, ubegin, uleave,"yes");
                                count1++;

                            }
                            else Console.WriteLine("this camper is not available");
                            Console.WriteLine("Do you Want to Add More campers yes OR no");
                            string userchoise = Console.ReadLine();
                           
                        } while (query.Count() < 4 && query.Count() > 0);


                        Console.WriteLine("the cabin now is full");

                    }
                //}
                else Console.WriteLine("the cabin is not available ");


            }
        }

        public static bool iscamperavailabel(int campId, DateTime start)
        {
            using (var context = new DataContext())
            {
                var query = from H in context.Historiks
                            where H.CamperId == campId
                            where H.Datestart == start
                            select new { theid = H.CamperId };
                if (query.Count() == 0)
                    return true;
                else return false;
            }

        }

        
        public static void bytacounselor()
        {
            Historik.LoadHistorik();
            Console.WriteLine("Please choose the newcounselorId ,the cabinId, and begin date");
            Console.WriteLine();
            int oldid= Convert.ToInt32(Console.ReadLine());
            int newcounselorid = Convert.ToInt32(Console.ReadLine ());
            int oldcabinid = Convert.ToInt32(Console.ReadLine ());
            DateTime startday = Convert.ToDateTime(Console.ReadLine ());
            if (methods.AvailableCounsler(newcounselorid, startday) == true)
            {
                using (var context = new DataContext())

                {
                    foreach (var l in context.Historiks.Where(p => p.CabinId == oldcabinid).Where(p => p.Datestart == startday).Where(p => p.CounselorId  == oldid) 
                      .ToList())
                    {
                        l.CounselorId = newcounselorid;
                        l.availablecounsler = "yes";
                    }
                }
            }
            else
            { Console.WriteLine("this counselor is not available in this time please try again"); }
        }


        public static void checkoutCamper()
        {
            AllCamper();
            Console.WriteLine("please enter the id for the camper");
            int camid = Convert.ToInt32(Console .ReadLine ());
            using (var context = new DataContext())

            {
                var query = from H in context.Historiks
                            where H.CamperId == camid
                            select new
                            {
                                cabin = H.CabinId,
                                start = H.Datestart
                            };
                Console.WriteLine("the Camper with this Id is in these cabins");
                foreach (var item in query )
                {
                    Console.WriteLine("the cabin Id IS "+ item.cabin  + "the date he was check in is: " +item.start);

                }
                Console.WriteLine("pleses enter the cabin id you want to leave from");
                int cabinid= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("pleses enter the chech in date");
                DateTime checkin = Convert.ToDateTime(Console.ReadLine());
                var l = context.Historiks.Where(p => p.CamperId == camid).Where(p => p.CabinId == cabinid).Where(p => p.Datestart==checkin)
                    .FirstOrDefault();
                if (l is Historik)
                {
                    context.Remove(l);
                    context.SaveChanges();
                    Console.WriteLine("done!");
                }

            }

            }

        public static void AddCamper()
        {
            Console.WriteLine("Add the Camper id ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the cabin id ");
            int idcabin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add the Camper chech in day ");
            DateTime checkin = Convert.ToDateTime(Console.ReadLine());
            methods.iscamperavailabel(id,checkin );
            using (var context = new DataContext())

            {
                if (methods.iscamperavailabel(id, checkin) == true)
                {
                    var query = from H in context.Historiks
                                where H.availablecounsler  == "yes"
                                where H.CabinId == idcabin
                                where H.Datestart == checkin
                               
                                select new
                                {
                                    cabin = H.CabinId,
                                    start = H.Datestart
                                };
                    if (query.Count() == 0)
                    { Console.WriteLine("sorry we didnt open this cabin Or the counselor is missing"); }
                    else
                    if (query.Count() < 4)
                    {
                        int Counselorid = context.Historiks.FirstOrDefault(x => x.CabinId == idcabin && x.Datestart == checkin && x.Datestop == checkin.AddDays(5)).CounselorId;
                        Historik.addHistorikout(idcabin, id, Counselorid, checkin, checkin.AddDays(5), "yes");
                        context.SaveChanges();
                        Console.WriteLine("done!");
                    }
                    else { Console.WriteLine("the Cabin is full"); }
                }
                else { Console.WriteLine("this camper is not available"); }
            }
            }



    }

}   
