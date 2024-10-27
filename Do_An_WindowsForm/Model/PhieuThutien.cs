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
<<<<<<< HEAD
        public long MaPTT { get; set; }

        public long MaPTP { get; set; }
=======
        public int MaPTT { get; set; }

        public int MaPTP { get; set; }
>>>>>>> feceeba78973ef1dfa91df68780f2d2205e2aaf2

        public int MaDV { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public int? ThanhTien { get; set; }

        public virtual CT_SuDungDV CT_SuDungDV { get; set; }
    }
}
