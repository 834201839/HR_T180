namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShiTi")]
    public partial class ShiTi
    {
        public Guid ID { get; set; }

        public Guid? STLID { get; set; }

        [Required]
        [StringLength(2)]
        public string Level { get; set; }

        public DateTime ChuTiShiJian { get; set; }

        [Required]
        [StringLength(50)]
        public string ChutiRenRong { get; set; }

        public Guid? UID { get; set; }

        [Required]
        [StringLength(200)]
        public string Sinfo { get; set; }

        public virtual ShiTiLei ShiTiLei { get; set; }

        public virtual User User { get; set; }
    }
}
