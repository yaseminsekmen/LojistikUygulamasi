//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojistikApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        public int personel_id { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string PersonelTel { get; set; }
        public int Departman_departman_id { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
