namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("18035_DB.navodnjavanje")]
    public partial class navodnjavanje
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_povrsina { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime datum { get; set; }

        public decimal? kolicina_vode_litri { get; set; }

        public int id_stanja { get; set; }

        public virtual polj_povrsina polj_povrsina { get; set; }

        public virtual stanje_navodnjavanja stanje_navodnjavanja { get; set; }
    }
}
