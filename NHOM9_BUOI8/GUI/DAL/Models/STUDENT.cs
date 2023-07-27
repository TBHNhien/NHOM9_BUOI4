namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STUDENT")]
    public partial class STUDENT
    {
        [StringLength(10)]
        public string STUDENTID { get; set; }

        [StringLength(255)]
        public string FULLNAME { get; set; }

        public double? AVERAGESCORE { get; set; }

        public int? FacultyId { get; set; }

        public int? MAJORID { get; set; }

        [StringLength(255)]
        public string AVATAR { get; set; }

        public virtual FACULTY FACULTY { get; set; }

        public virtual FACULTY FACULTY1 { get; set; }

        public virtual MAJOR MAJOR { get; set; }
    }
}
