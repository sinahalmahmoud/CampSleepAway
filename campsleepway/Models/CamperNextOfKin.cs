using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.connect;


namespace campsleepway.Models
{
    public class CamperNextOfKin
    {
        public int CamperNextOfKinId { get; set; }
        public int CamperId { get; set; }
        [ForeignKey("CamperId")]
        public Camper Camper { get; set; }

        public int NextOfKinId { get; set; }
        [ForeignKey("NextOfKinId")]
        public NextOfKin NextOfKin { get; set; }
        public string CamperNAme { get; set; }
        public string NextNAme { get; set; }


        public static void AddCamperNextOfKin()
        {
            using (var context = new DataContext())
            {
                var CNextOfKin1 = new CamperNextOfKin()
                {
                    CamperId = 1,
                    CamperNAme = "Ghaleb",
                    NextOfKinId = 1,
                    NextNAme = "Haytham",



                };
                var CNextOfKin2 = new CamperNextOfKin()
                {
                    CamperId = 1,
                    CamperNAme = "Ghaleb",
                    NextOfKinId = 5,
                    NextNAme = "Bareaa",



                };
                var CNextOfKin3 = new CamperNextOfKin()
                {
                    CamperId = 2,
                    CamperNAme = "Lara",
                    NextOfKinId = 2,
                    NextNAme = "Reem",



                };
                var CNextOfKin4 = new CamperNextOfKin()
                {
                    CamperId = 2,
                    CamperNAme = "Lara",
                    NextOfKinId = 6,
                    NextNAme = "Mohamed",



                };

                var CNextOfKin5 = new CamperNextOfKin()
                {
                    CamperId = 3,
                    CamperNAme = "Rakan",
                    NextOfKinId = 3,
                    NextNAme = "Malek",



                };

                var CNextOfKin6 = new CamperNextOfKin()
                {
                    CamperId = 4,
                    CamperNAme = "Omar",
                    NextOfKinId = 3,
                    NextNAme = "Malek",



                };
                var CNextOfKin7 = new CamperNextOfKin()
                {
                    CamperId = 5,
                    CamperNAme = "Remi",
                    NextOfKinId = 4,
                    NextNAme = "Lana",



                };



                context.CamperNextOfKin.AddRange(CNextOfKin1, CNextOfKin2, CNextOfKin3, CNextOfKin4
                    , CNextOfKin5, CNextOfKin6, CNextOfKin7);
                context.SaveChanges();

            }
        }
    }
}