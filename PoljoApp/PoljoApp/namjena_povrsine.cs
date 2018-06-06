namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.namjena_povrsine")]
    public partial class namjena_povrsine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public namjena_povrsine()
        {
            polj_povrsina = new HashSet<polj_povrsina>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string namjena { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<polj_povrsina> polj_povrsina { get; set; }
    }
}
