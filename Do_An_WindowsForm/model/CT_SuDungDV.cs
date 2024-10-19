namespace Do_An_WindowsForm.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_SuDungDV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaPSDDV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDV { get; set; }

        public int? ChiSoCu { get; set; }

        public int? ChiSoMoi { get; set; }

        public int? SoLuong { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual PhieuSuDungDV PhieuSuDungDV { get; set; }
    }
}
