//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoljoAppVerzija2
{
    using System;
    using System.Collections.Generic;
    
    public partial class zastita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zastita()
        {
            this.prskanje = new HashSet<prskanje>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public string koncentracija { get; set; }
        public int id_vrste_zastite { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prskanje> prskanje { get; set; }
        public virtual vrsta_zastite vrsta_zastite { get; set; }
    }
}
