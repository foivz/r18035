namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.sadni_materijal")]
    public partial class sadni_materijal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sadni_materijal()
        {
            sadnja = new HashSet<sadnja>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        [StringLength(45)]
        public string jedinicna_mjera { get; set; }

        public int id_vrste_materijala { get; set; }

        public virtual vrsta_sadnog_materijala vrsta_sadnog_materijala { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sadnja> sadnja { get; set; }
    }
}
