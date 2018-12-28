namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PeiXunJiHua")]
    public partial class PeiXunJiHua
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(30)]
        public string PXName { get; set; }

        [Required]
        [StringLength(60)]
        public string Teacher { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(30)]
        public string CanXuanRen { get; set; }

        [StringLength(200)]
        public string Pinfo { get; set; }

        [StringLength(200)]
        public string Opinion { get; set; }

        public int? State { get; set; }

        public Guid? FKID { get; set; }

        public virtual FanKui FanKui { get; set; }
    }
}
