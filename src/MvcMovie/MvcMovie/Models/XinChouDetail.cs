namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XinChouDetail")]
    public partial class XinChouDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid XCID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid XMID { get; set; }

        public int Price { get; set; }

        public virtual XinChou XinChou { get; set; }

        public virtual XinChouXiangMu XinChouXiangMu { get; set; }
    }
}
