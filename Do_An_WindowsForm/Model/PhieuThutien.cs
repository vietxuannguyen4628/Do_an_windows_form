namespace Do_An_WindowsForm.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThutien")]
    public partial class PhieuThutien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPTT { get; set; }

        public int MaPTP { get; set; }

        public int MaDV { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public int? ThanhTien { get; set; }

        public virtual CT_SuDungDV CT_SuDungDV { get; set; }
    }
}
