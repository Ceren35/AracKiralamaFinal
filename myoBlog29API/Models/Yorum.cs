//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myoBlog29API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorum
    {
        public int YorumId { get; set; }
        public string YorumIcerik { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> UyeId { get; set; }
        public Nullable<int> MakaleId { get; set; }
    
        public virtual Makale Makale { get; set; }
        public virtual Uye Uye { get; set; }
    }
}