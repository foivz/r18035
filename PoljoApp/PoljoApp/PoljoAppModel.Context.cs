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
    
        public DbSet<namjena_povrsine> namjena_povrsine { get; set; }
        public DbSet<polj_povrsina> polj_povrsina { get; set; }
        public DbSet<sadni_materijal> sadni_materijal { get; set; }
        public DbSet<sadnja> sadnja { get; set; }
        public DbSet<vrsta_sadnog_materijala> vrsta_sadnog_materijala { get; set; }
        public DbSet<vrsta_zastite> vrsta_zastite { get; set; }
        public DbSet<zastita> zastita { get; set; }
        public DbSet<SadnjaView> SadnjaView { get; set; }
        public DbSet<Djelatnik> DjelatnikSet { get; set; }
        public DbSet<Navodnjavanje> NavodnjavanjeSet { get; set; }
        public DbSet<Prskanje> PrskanjeSet { get; set; }
        public DbSet<StanjeNavodnjavanja> StanjeNavodnjavanja { get; set; }
        public DbSet<NavodnjavanjeView> NavodnjavanjeViewSet { get; set; }
        public DbSet<PrskanjeView> PrskanjeViewSet { get; set; }
    }
}
