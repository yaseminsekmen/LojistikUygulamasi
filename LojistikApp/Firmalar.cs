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
    
    public partial class Firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmalar()
        {
            this.AliciFirmalar = new HashSet<AliciFirmalar>();
            this.TasiyiciFirmalar = new HashSet<TasiyiciFirmalar>();
            this.UreticiFirmalar = new HashSet<UreticiFirmalar>();
            this.Departman = new HashSet<Departman>();
            this.Sevkiyat = new HashSet<Sevkiyat>();
        }
    
        public int firma_id { get; set; }
        public string FirmaTipi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AliciFirmalar> AliciFirmalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TasiyiciFirmalar> TasiyiciFirmalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UreticiFirmalar> UreticiFirmalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Departman> Departman { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sevkiyat> Sevkiyat { get; set; }
    }
}