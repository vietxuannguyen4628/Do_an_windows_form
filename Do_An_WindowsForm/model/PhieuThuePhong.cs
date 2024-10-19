namespace Do_An_WindowsForm.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThuePhong")]
    public partial class PhieuThuePhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuThuePhong()
        {
            PhieuDenBus = new HashSet<PhieuDenBu>();
            PhieuSuDungDVs = new HashSet<PhieuSuDungDV>();
            PhieuTraPhongs = new HashSet<PhieuTraPhong>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaPTP { get; set; }

        public int MaPhong { get; set; }

        public int MaKH { get; set; }

        public int? TienDacCoc { get; set; }

        public DateTime? NgayThue { get; set; }

        public byte? DaThanhToan { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDenBu> PhieuDenBus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuSuDungDV> PhieuSuDungDVs { get; set; }

        public virtual Phong Phong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTraPhong> PhieuTraPhongs { get; set; }
    }
}
