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
    
    public partial class navodnjavanje
    {
        public int id_povrsina { get; set; }
        public System.DateTime datum { get; set; }
        public Nullable<decimal> kolicina_vode_litri { get; set; }
        public int id_stanja { get; set; }
    
        public virtual polj_povrsina polj_povrsina { get; set; }
        public virtual stanje_navodnjavanja stanje_navodnjavanja { get; set; }
    }
}