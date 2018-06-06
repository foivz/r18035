namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.prskanje")]
    public partial class prskanje
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_povrsina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_zastita { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime datum { get; set; }

        [StringLength(45)]
        public string opis { get; set; }

        public int id_djelatnik { get; set; }

        public virtual djelatnik djelatnik { get; set; }

        public virtual polj_povrsina polj_povrsina { get; set; }

        public virtual zastita zastita { get; set; }
    }
}
