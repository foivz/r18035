namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.zastita")]
    public partial class zastita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zastita()
        {
            prskanje = new HashSet<prskanje>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string naziv { get; set; }

        [StringLength(20)]
        public string koncentracija { get; set; }

        public int id_vrste_zastite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prskanje> prskanje { get; set; }

        public virtual vrsta_zastite vrsta_zastite { get; set; }
    }
}
