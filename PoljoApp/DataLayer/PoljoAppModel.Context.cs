﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PoljoAppEntities : DbContext
    {
        public PoljoAppEntities()
            : base("name=PoljoAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Djelatnik> Djelatnik { get; set; }
        public DbSet<NamjenaPovrsine> namjena_povrsine { get; set; }
        public DbSet<Navodnjavanje> Navodnjavanje { get; set; }
        public DbSet<PoljPovrsina> polj_povrsina { get; set; }
        public DbSet<Prskanje> Prskanje { get; set; }
        public DbSet<SadniMaterijal> sadni_materijal { get; set; }
        public DbSet<Sadnja> sadnja { get; set; }
        public DbSet<StanjeNavodnjavanja> StanjeNavodnjavanja { get; set; }
        public DbSet<VrstaSadnogMaterijala> vrsta_sadnog_materijala { get; set; }
        public DbSet<vrsta_zastite> vrsta_zastite { get; set; }
        public DbSet<zastita> zastita { get; set; }
        public DbSet<NavodnjavanjeView> NavodnjavanjeView { get; set; }
        public DbSet<PoljPovrsinaView> PoljPovrsinaView { get; set; }
        public DbSet<PrskanjeView> PrskanjeView { get; set; }
        public DbSet<SadniMaterijalView> SadniMaterijalView { get; set; }
        public DbSet<SadnjaView> SadnjaView { get; set; }
        public DbSet<ZastitaView> ZastitaView { get; set; }
    }
}