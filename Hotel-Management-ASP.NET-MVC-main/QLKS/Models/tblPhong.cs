
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
    
public partial class tblPhong
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tblPhong()
    {

        this.tblPhieuDatPhongs = new HashSet<tblPhieuDatPhong>();

    }


    public int ma_phong { get; set; }

    public string so_phong { get; set; }

    public Nullable<int> loai_phong { get; set; }

    public Nullable<int> ma_tang { get; set; }

    public Nullable<int> ma_tinh_trang { get; set; }



    public virtual tblLoaiPhong tblLoaiPhong { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tblPhieuDatPhong> tblPhieuDatPhongs { get; set; }

    public virtual tblTang tblTang { get; set; }

    public virtual tblTinhTrangPhong tblTinhTrangPhong { get; set; }

}

}
