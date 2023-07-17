namespace QLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [StringLength(6)]
        public string MANV { get; set; }

        [StringLength(20)]
        public string TENNV { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(2)]
        public string MAPB { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
