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
    
    public partial class djelatnik
    {
        public djelatnik()
        {
            this.prskanje = new HashSet<prskanje>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string broj_telefona { get; set; }
        public Nullable<int> admin { get; set; }
    
        public virtual ICollection<prskanje> prskanje { get; set; }
    }
}
