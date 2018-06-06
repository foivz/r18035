namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.sadnja")]
    public partial class sadnja
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_povrsina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_materijal { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime datum_sadnje { get; set; }

        [StringLength(70)]
        public string kolicina { get; set; }

        public virtual polj_povrsina polj_povrsina { get; set; }

        public virtual sadni_materijal sadni_materijal { get; set; }
    }
}
