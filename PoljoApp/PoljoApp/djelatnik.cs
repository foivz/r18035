namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.djelatnik")]
    public partial class djelatnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public djelatnik()
        {
            prskanje = new HashSet<prskanje>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string ime { get; set; }

        [Required]
        [StringLength(45)]
        public string prezime { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string lozinka { get; set; }

        [StringLength(45)]
        public string broj_telefona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prskanje> prskanje { get; set; }
    }
}
