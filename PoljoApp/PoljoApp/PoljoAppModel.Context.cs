﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoljoAppVerzija2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<djelatnik> djelatnik { get; set; }
        public DbSet<namjena_povrsine> namjena_povrsine { get; set; }
        public DbSet<navodnjavanje> navodnjavanje { get; set; }
        public DbSet<polj_povrsina> polj_povrsina { get; set; }
        public DbSet<prskanje> prskanje { get; set; }
        public DbSet<sadni_materijal> sadni_materijal { get; set; }
        public DbSet<sadnja> sadnja { get; set; }
        public DbSet<stanje_navodnjavanja> stanje_navodnjavanja { get; set; }
        public DbSet<vrsta_sadnog_materijala> vrsta_sadnog_materijala { get; set; }
        public DbSet<vrsta_zastite> vrsta_zastite { get; set; }
        public DbSet<zastita> zastita { get; set; }
        public DbSet<prskanjeView> prskanjeView { get; set; }
    }
}
