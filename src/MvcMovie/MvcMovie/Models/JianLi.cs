namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JianLi")]
    public partial class JianLi
    {
        public Guid ID { get; set; }

        public Guid? ZWID { get; set; }

        [Required]
        [StringLength(30)]
        public string JName { get; set; }

        [Required]
        [StringLength(2)]
        public string Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string ZhaoPingLeiXing { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(30)]
        public string SuoZaiDi { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string MianMao { get; set; }

        [Required]
        [StringLength(20)]
        public string ShenFenZheng { get; set; }

        [Required]
        [StringLength(40)]
        public string BiYe { get; set; }

        [Required]
        [StringLength(20)]
        public string XueLi { get; set; }

        [Required]
        [StringLength(30)]
        public string ZhuanYe { get; set; }

        [Required]
        [StringLength(10)]
        public string JingYan { get; set; }

        [Required]
        [StringLength(200)]
        public string XinZiYaoQiu { get; set; }

        public bool ShiFouZaiZhi { get; set; }

        public bool YingJieSheng { get; set; }

        public DateTime DengJiDate { get; set; }

        [Required]
        [StringLength(200)]
        public string LVLi { get; set; }

        public Guid? MID { get; set; }

        public int State { get; set; }

        public virtual MianShi MianShi { get; set; }

        public virtual ZhiWei ZhiWei { get; set; }
    }
}
