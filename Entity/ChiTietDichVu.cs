//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDichVu
    {
        public int mathuephong { get; set; }
        public int dichvu { get; set; }
        public Nullable<System.DateTime> thoigian { get; set; }
        public Nullable<int> soluong { get; set; }
        public long id { get; set; }
    
        public virtual DichVu DichVu1 { get; set; }
        public virtual ThuePhong ThuePhong { get; set; }
    }
}
