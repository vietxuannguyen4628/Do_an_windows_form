namespace Do_An_WindowsForm.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDenBu")]
    public partial class PhieuDenBu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaPDB { get; set; }

        public long MaPTP { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        public int? TienBoiThuong { get; set; }

        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
