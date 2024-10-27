namespace Do_An_WindowsForm.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANHTHUTHEOPHONG")]
    public partial class DOANHTHUTHEOPHONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhong { get; set; }

        public int? TONG_TIEN_PHONG { get; set; }

        public int? DTDICHVU { get; set; }

        public int? DTPHONG { get; set; }
    }
}
