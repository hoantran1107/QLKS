
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QLKS.Models
{

using System;
    using System.Collections.Generic;
    
public partial class tblPhieuDatPhong
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblPhieuDatPhong()
    {

        this.tblHoaDons = new HashSet<tblHoaDon>();

    }


    public int ma_pdp { get; set; }

    public string ma_kh { get; set; }

    public Nullable<System.DateTime> ngay_dat { get; set; }

    public Nullable<System.DateTime> ngay_vao { get; set; }

    public Nullable<System.DateTime> ngay_ra { get; set; }

    public Nullable<int> ma_phong { get; set; }

    public string thong_tin_khach_thue { get; set; }

    public Nullable<int> ma_tinh_trang { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tblHoaDon> tblHoaDons { get; set; }

    public virtual tblKhachHang tblKhachHang { get; set; }

    public virtual tblPhong tblPhong { get; set; }

    public virtual tblTinhTrangPhieuDatPhong tblTinhTrangPhieuDatPhong { get; set; }

}

}
