//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip_proje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMesajlar
    {
        public int ID { get; set; }
        public Nullable<int> Gonderen { get; set; }
        public Nullable<int> Alici { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        public virtual tblFirmalar tblFirmalar { get; set; }
        public virtual tblFirmalar tblFirmalar1 { get; set; }
    }
}
