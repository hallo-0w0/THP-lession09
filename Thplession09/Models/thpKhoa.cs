//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThpKTGiuaKi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class thpKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thpKhoa()
        {
            this.thpSinhViens = new HashSet<thpSinhVien>();
        }
    
        public string ThpMaKH { get; set; }
        public string ThpTenKH { get; set; }
        public Nullable<bool> ThpTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thpSinhVien> thpSinhViens { get; set; }
    }
}