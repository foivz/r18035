//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class vrsta_zastite
    {
        public vrsta_zastite()
        {
            this.zastita = new HashSet<zastita>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<zastita> zastita { get; set; }
    }
}