namespace Do_An_WindowsForm.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            PhieuThuePhongs = new HashSet<PhieuThuePhong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKH { get; set; }

        [StringLength(70)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string CMND_CanCuoc { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(150)]
        public string QueQuan { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(30)]
        public string NgheNghiep { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThuePhong> PhieuThuePhongs { get; set; }
    }
}
