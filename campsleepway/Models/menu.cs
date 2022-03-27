using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;
using campsleepway.Models;

namespace campsleepway.Models
{
    public class menu
    {
        public static void mainmenu()
        {

            Console.WriteLine("1. View data dabase \n" +
                              "2. Search for Camper by Cabin \n" +
                              "3. Search for Camper by Counsler \n" +
                              "4. Print Camper with all Nextofkin orderd by Cabin \n" +
                              "5. Filling Campers to Cabin \n" +
                              "6. GRUDA tabels \n" +
                              "7. Change Counselor for Cabin \n" +
                              "8. Dlete Couselor from cabin \n" +
                              "9. Check out Camper \n" +
                              "10. Add Camper \n" +
                              "11. Exit \n" +
                              "  Please select an option \n");
            do
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();

                        submenu();
                        break;
                    case "2":
                        methods.AllCabin();
                        Console.WriteLine("please enter the name of cabin ");
                        string c = Console.ReadLine();
                        methods.getcamperbycabin(c);
                        Console.ReadKey();
                        Console.Clear();
                        mainmenu();
                        break;

                    case "3":
                        methods.AllCounselor();

                        Console.WriteLine("please enter the name of couslore");
                        string counler = Console.ReadLine();
                        methods.getcamperbycouclor(counler);
                        Console.ReadKey();
                        Console.Clear();
                        mainmenu();
                        break;

                    case "4":
                       
                        methods.campernextofkin();
                        Console.ReadKey();
                        Console.Clear();
                        mainmenu();
                        break;
                    case "5":
                        Console.Clear();
                        methods.AllCabin();

                        Console.WriteLine("please enter the name of the cabin ");
                        methods.addcabincamper();
                        Console.ReadKey();
                        Console.Clear();
                        mainmenu();
                        break;

                    case "6":
                        Console.Clear();
                        CRUD ();
                        break;
                    case "7":
                        Console.Clear();
                        Historik.uodatecounselor();
                        mainmenu();


                        break;
                    case "8":
                        Console.Clear();
                        Historik.deletecounselor();
                        mainmenu();
                        break;
                    case "9":
                        Console.Clear();
                        methods.checkoutCamper();
                        mainmenu();
                        break;
                       
                    case "10":
                        methods.AddCamper();
                        mainmenu();
                        break;
                    case "11":
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
        public static void submenu()
        {
            Console.WriteLine("Please choose on of the options :\n" +
                              "1. view All Cabins \n" +
                              "2. view All Campers \n" +
                              "3. view All Counselor \n" +
                              "4. view All Nextofkin \n" +
                              "5. view All Historik \n" +
                              "6. return to the main menu :");

            do
            {
                string input1 = Console.ReadLine();
                switch (input1)
                {
                    case "1":
                        Console.Clear();
                        methods.AllCabin();
                        submenu();
                        break;
                    case "2":
                        Console.Clear();
                        methods.AllCamper();
                        submenu();
                        break;
                    case "3":
                        Console.Clear();
                        methods.AllCounselor();
                        submenu();
                        break;
                    case "4":
                        Console.Clear();
                        methods.Allnextofkin();
                        submenu();
                        break;
                    case "5":

                        Console.Clear();
                        methods.AllHIstorik();
                        submenu();
                        break;
                    case "6":
                        Console.Clear();
                        mainmenu();
                        break;
                }
            } while (true);

        }

        public static void CRUD()
        {
            Console.Clear();
            Console.WriteLine(" 1.Add functions \n" +
                              " 2.Delete functions \n" +
                              " 3.Uppdate Functions \n" +
                              " 4.Return to main menu \n");
            do
            {
                string input3 = Console.ReadLine();
                switch (input3)
                {
                    case "1":
                        Console.WriteLine("enter the name of the table  Cabin  Camper  Counselor  NextOfKin");

                        string table = Console.ReadLine();
                        switch (table)
                        {
                            case "Cabin":
                                Console.WriteLine("enter the name of the cabin");
                                string cabin = Console.ReadLine();
                                Console.WriteLine("enter the capacity");
                                int c = Convert.ToInt32(Console.ReadLine());
                                Cabin.AddCabin(cabin, c);
                                Console.WriteLine("Done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;

                            case "Camper":
                                //string Firstname, string Middelname,string Lastnamme,string Address,int Age
                                Console.WriteLine("enter the first name of the camper");
                                string Firstname = Console.ReadLine();
                                Console.WriteLine("enter the middle name of the camper");
                                string Middelname = Console.ReadLine();
                                Console.WriteLine("enter the last name of the camper");
                                string Lastnamme = Console.ReadLine();
                                Console.WriteLine("enter the address of the camper");
                                string Address = Console.ReadLine();
                                Console.WriteLine("enter the age");
                                int Age = Convert.ToInt32(Console.ReadLine());
                                Camper.AddCamper(Firstname, Middelname, Lastnamme, Address, Age);
                                Console.WriteLine("Done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;

                            case "Counselor":
                                //string Firstname, string Lastname, string Phone, string Email
                                Console.WriteLine("enter the first name");
                                string Firstnam = Console.ReadLine();
                                Console.WriteLine("enter the last name ");
                                string Lastnamm = Console.ReadLine();
                                Console.WriteLine("enter the Phone");
                                string Phone = Console.ReadLine();
                                Console.WriteLine("enter the Email");
                                string Email = Console.ReadLine();
                                Counselor.AddCounselro(Firstnam, Lastnamm, Phone, Email);
                                Console.WriteLine("Done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;

                            case "NextOfKin":
                                //string Firstname, string Lastname, string Address, string Telephone
                                Console.WriteLine("enter the first name");
                                string Firstna = Console.ReadLine();
                                Console.WriteLine("enter the last name ");
                                string Lastnam = Console.ReadLine();
                                Console.WriteLine("enter the Address");
                                string Addres = Console.ReadLine();
                                Console.WriteLine("enter the Telephone");
                                string Telephone = Console.ReadLine();
                                NextOfKin.AddNextOfKin(Firstna, Lastnam, Addres, Telephone);
                                Console.WriteLine("Done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;




                        }
                        break;





                    case "2":
                        Console.WriteLine("enter the name of the table");
                        string delete = Console.ReadLine();
                        switch (delete)
                        {
                            case "Cabin":
                                Console.WriteLine(" name\\id");
                                string by = Console.ReadLine();
                                switch (by)
                                {
                                    case "name":
                                        Console.WriteLine("enter the name you want to delete");
                                        string s = Console.ReadLine();
                                        Cabin.DeleteCabinBYname(s);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;
                                    case "id":
                                        Console.WriteLine("enter th id you want to delete");
                                        int i = Convert.ToInt32(Console.ReadLine());
                                        Cabin.DeleteCabinBYid(i);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;


                                }
                                break;

                            case "Camper":
                                Console.WriteLine(" name\\id");
                                string by1 = Console.ReadLine();
                                switch (by1)
                                {
                                    case "name":
                                        Console.WriteLine("enter the name you want to delete");
                                        string s = Console.ReadLine();
                                        Camper.DeleteCamperbyname(s);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;
                                    case "id":
                                        Console.WriteLine("enter th id you want to delete");
                                        int i = Convert.ToInt32(Console.ReadLine());
                                        Camper.DeleteCamperbyId(i);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;


                                }
                                break;

                            case "Counselor":
                                Console.WriteLine(" name\\id");
                                string by2 = Console.ReadLine();
                                switch (by2)
                                {
                                    case "name":
                                        Console.WriteLine("enter the name");
                                        string s = Console.ReadLine();
                                        Counselor.DeleteCounselorbyname(s);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;
                                    case "id":
                                        Console.WriteLine("enter th id");
                                        int i = Convert.ToInt32(Console.ReadLine());
                                        Counselor.DeleteCounselorbyId(i);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;


                                }
                                break;

                            case "NextOfKin":
                                Console.WriteLine(" name\\id");
                                string by3 = Console.ReadLine();
                                switch (by3)
                                {
                                    case "name":
                                        Console.WriteLine("enter the name");
                                        string s = Console.ReadLine();
                                        NextOfKin.DeleteNextOfKinbyname(s);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;
                                    case "id":
                                        Console.WriteLine("enter th id");
                                        int i = Convert.ToInt32(Console.ReadLine());
                                        NextOfKin.DeleteNextOfKinbyId(i);
                                        Console.WriteLine("ppress any key to come back");
                                        CRUD();
                                        break;


                                }
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("enter the name of the table");
                        string up = Console.ReadLine();
                        switch (up)
                        {
                            case "Cabin":
                                Console.WriteLine("enter th id");
                                int i = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the name");
                                string s = Console.ReadLine();
                                Cabin.UppdateCAbiname(i, s);
                                Console.WriteLine("done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;

                            case "Camper":
                                Console.WriteLine("enter th id");
                                int ii = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the first name");
                                string fs = Console.ReadLine();

                                Console.WriteLine("enter the last name");
                                string ls = Console.ReadLine();

                                Camper.UppdateCampername(ii, fs, ls);
                                Console.WriteLine("done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;

                            case "Counselor":
                                Console.WriteLine("enter th id");
                                int iii = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("enter the first name");
                                string fss = Console.ReadLine();

                                Console.WriteLine("enter the last name");
                                string lss = Console.ReadLine();

                                Counselor.UppdateCounselorrname(iii, fss, lss);
                                Console.WriteLine("done");
                                Console.WriteLine("ppress any key to come back");
                                CRUD();
                                break;


                        }
                        break;
                    case "4":
                        mainmenu();
                        break;
                } 
            } while (true);

        } } }
    
