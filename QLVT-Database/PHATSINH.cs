//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLVT_Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHATSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHATSINH()
        {
            this.CT_PHATSINH = new HashSet<CT_PHATSINH>();
        }
    
        public string PHIEU { get; set; }
        public System.DateTime NGAY { get; set; }
        public string LOAI { get; set; }
        public string HOTENKH { get; set; }
        public int MANV { get; set; }
        public string LYDO { get; set; }
        public string MAKHO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHATSINH> CT_PHATSINH { get; set; }
        public virtual KHO KHO { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
