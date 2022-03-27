using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using campsleepway.Models;
using Microsoft.EntityFrameworkCore;


namespace campsleepway.connect
{
    public class DataContext : DbContext

    {
        public DbSet<Cabin> Cabins { get; set; }
        public DbSet<Camper> Campers { get; set; }
        public DbSet<Counselor> Counselors { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<Historik> Historiks { get; set; }
        public DbSet<CamperNextOfKin> CamperNextOfKin { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-KT5D1OQ\\SQLEXPRESS; Initial Catalog = SinahAlmahmoud; Integrated Security = True");
        }
       
    }
}
