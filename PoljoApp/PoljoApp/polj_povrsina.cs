//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    
    public partial class polj_povrsina
    {
        public polj_povrsina()
        {
            this.sadnja = new HashSet<sadnja>();
            this.Navodnjavanje = new HashSet<Navodnjavanje>();
            this.Prskanje = new HashSet<Prskanje>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public decimal povrsina_m2 { get; set; }
        public int id_namjene { get; set; }
        public decimal x_koordinata { get; set; }
        public decimal y_koordinata { get; set; }
    
        public virtual namjena_povrsine namjena_povrsine { get; set; }
        public virtual ICollection<sadnja> sadnja { get; set; }
        public virtual ICollection<Navodnjavanje> Navodnjavanje { get; set; }
        public virtual ICollection<Prskanje> Prskanje { get; set; }
    }
}
