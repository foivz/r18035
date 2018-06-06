namespace PoljoAppVerzija2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PoljoAppModel : DbContext
    {
        public PoljoAppModel()
            : base("name=PoljoAppModel")
        {
        }

        public virtual DbSet<djelatnik> djelatnik { get; set; }
        public virtual DbSet<namjena_povrsine> namjena_povrsine { get; set; }
        public virtual DbSet<navodnjavanje> navodnjavanje { get; set; }
        public virtual DbSet<polj_povrsina> polj_povrsina { get; set; }
        public virtual DbSet<prskanje> prskanje { get; set; }
        public virtual DbSet<sadni_materijal> sadni_materijal { get; set; }
        public virtual DbSet<sadnja> sadnja { get; set; }
        public virtual DbSet<stanje_navodnjavanja> stanje_navodnjavanja { get; set; }
        public virtual DbSet<vrsta_sadnog_materijala> vrsta_sadnog_materijala { get; set; }
        public virtual DbSet<vrsta_zastite> vrsta_zastite { get; set; }
        public virtual DbSet<zastita> zastita { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<djelatnik>()
                .Property(e => e.ime)
                .IsUnicode(false);

            modelBuilder.Entity<djelatnik>()
                .Property(e => e.prezime)
                .IsUnicode(false);

            modelBuilder.Entity<djelatnik>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<djelatnik>()
                .Property(e => e.lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<djelatnik>()
                .Property(e => e.broj_telefona)
                .IsUnicode(false);

            modelBuilder.Entity<djelatnik>()
                .HasMany(e => e.prskanje)
                .WithRequired(e => e.djelatnik)
                .HasForeignKey(e => e.id_djelatnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<namjena_povrsine>()
                .Property(e => e.namjena)
                .IsUnicode(false);

            modelBuilder.Entity<namjena_povrsine>()
                .HasMany(e => e.polj_povrsina)
                .WithRequired(e => e.namjena_povrsine)
                .HasForeignKey(e => e.id_namjene)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<navodnjavanje>()
                .Property(e => e.kolicina_vode_litri)
                .HasPrecision(10, 2);

            modelBuilder.Entity<polj_povrsina>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<polj_povrsina>()
                .Property(e => e.povrsina_m2)
                .HasPrecision(10, 2);

            modelBuilder.Entity<polj_povrsina>()
                .HasMany(e => e.navodnjavanje)
                .WithRequired(e => e.polj_povrsina)
                .HasForeignKey(e => e.id_povrsina);

            modelBuilder.Entity<polj_povrsina>()
                .HasMany(e => e.prskanje)
                .WithRequired(e => e.polj_povrsina)
                .HasForeignKey(e => e.id_povrsina);

            modelBuilder.Entity<polj_povrsina>()
                .HasMany(e => e.sadnja)
                .WithRequired(e => e.polj_povrsina)
                .HasForeignKey(e => e.id_povrsina)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<prskanje>()
                .Property(e => e.opis)
                .IsUnicode(false);

            modelBuilder.Entity<sadni_materijal>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<sadni_materijal>()
                .Property(e => e.jedinicna_mjera)
                .IsUnicode(false);

            modelBuilder.Entity<sadni_materijal>()
                .HasMany(e => e.sadnja)
                .WithRequired(e => e.sadni_materijal)
                .HasForeignKey(e => e.id_materijal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sadnja>()
                .Property(e => e.kolicina)
                .IsUnicode(false);

            modelBuilder.Entity<stanje_navodnjavanja>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<stanje_navodnjavanja>()
                .HasMany(e => e.navodnjavanje)
                .WithRequired(e => e.stanje_navodnjavanja)
                .HasForeignKey(e => e.id_stanja)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vrsta_sadnog_materijala>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<vrsta_sadnog_materijala>()
                .HasMany(e => e.sadni_materijal)
                .WithRequired(e => e.vrsta_sadnog_materijala)
                .HasForeignKey(e => e.id_vrste_materijala)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vrsta_zastite>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<vrsta_zastite>()
                .HasMany(e => e.zastita)
                .WithRequired(e => e.vrsta_zastite)
                .HasForeignKey(e => e.id_vrste_zastite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<zastita>()
                .Property(e => e.naziv)
                .IsUnicode(false);

            modelBuilder.Entity<zastita>()
                .Property(e => e.koncentracija)
                .IsUnicode(false);

            modelBuilder.Entity<zastita>()
                .HasMany(e => e.prskanje)
                .WithRequired(e => e.zastita)
                .HasForeignKey(e => e.id_zastita);
        }
    }
}
