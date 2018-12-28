namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShenHeRen")]
    public partial class ShenHeRen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShenHeID { get; set; }

        [Key]
        [Column("ShenHeRen", Order = 1)]
        public Guid ShenHeRen1 { get; set; }

        [Required]
        [StringLength(20)]
        public string ShenHeYiJian { get; set; }

        public virtual ShenHe ShenHe { get; set; }

        public virtual User User { get; set; }
    }
}
