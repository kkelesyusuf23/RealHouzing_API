using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MM84V2T\\SQLEXPRESS;initial catalog=DBRealHouzingApi;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Buying> Buyings { get; set; }
        public DbSet<Commercial> Commercials { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Find> Finds { get; set; }
        public DbSet<Join> Joins { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<News> Newss { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<RegisterProperty> RegisterProperties { get; set; }
        public DbSet<SSS> SSSes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }




    }
}
