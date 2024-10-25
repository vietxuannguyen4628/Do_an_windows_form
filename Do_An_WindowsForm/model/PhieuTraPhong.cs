namespace Do_An_WindowsForm.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTraPhong")]
    public partial class PhieuTraPhong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaPTrP { get; set; }

        public long MaPTP { get; set; }

        public DateTime? NgayTra { get; set; }

        public byte? DaThanhtoan { get; set; }

        public virtual PhieuThuePhong PhieuThuePhong { get; set; }
    }
}
