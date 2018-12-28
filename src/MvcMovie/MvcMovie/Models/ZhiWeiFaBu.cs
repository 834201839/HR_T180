namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZhiWeiFaBu")]
    public partial class ZhiWeiFaBu
    {
        public Guid ID { get; set; }

        public Guid? DID { get; set; }

        public Guid? ZID { get; set; }

        public Guid? DengJiRen { get; set; }

        public int Number { get; set; }

        public DateTime DengJiDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(200)]
        public string MiaoShu { get; set; }

        [Required]
        [StringLength(200)]
        public string YaoQiu { get; set; }

        public virtual Department Department { get; set; }

        public virtual User User { get; set; }

        public virtual ZhiWei ZhiWei { get; set; }
    }
}
