namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.polj_povrsina")]
    public partial class polj_povrsina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public polj_povrsina()
        {
            navodnjavanje = new HashSet<navodnjavanje>();
            prskanje = new HashSet<prskanje>();
            sadnja = new HashSet<sadnja>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string naziv { get; set; }

        public decimal povrsina_m2 { get; set; }

        [Required]
        public DbGeometry koordinate { get; set; }

        public int id_namjene { get; set; }

        public virtual namjena_povrsine namjena_povrsine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<navodnjavanje> navodnjavanje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prskanje> prskanje { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sadnja> sadnja { get; set; }
    }
}
