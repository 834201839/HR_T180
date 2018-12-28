namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangAn")]
    public partial class DangAn
    {
        public Guid ID { get; set; }

        public Guid? DangAnZhuangTai { get; set; }

        public Guid? ZWID { get; set; }

        [Required]
        [StringLength(200)]
        public string ImgPath { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(2)]
        public string Sex { get; set; }

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

        public Guid? XID { get; set; }

        [Required]
        [StringLength(30)]
        public string YinHang { get; set; }

        [Required]
        [StringLength(30)]
        public string YinHangKaHao { get; set; }

        [Required]
        [StringLength(50)]
        public string SheBaoKaHao { get; set; }

        public DateTime JianDangDate { get; set; }

        [Required]
        [StringLength(200)]
        public string LVLi { get; set; }

        public Guid? DengJiRen { get; set; }

        [Required]
        [StringLength(40)]
        public string JiaTingXinXi { get; set; }

        [StringLength(80)]
        public string BeiZhu { get; set; }

        public int? State { get; set; }

        public virtual DangAnState DangAnState { get; set; }

        public virtual User User { get; set; }

        public virtual XinChou XinChou { get; set; }

        public virtual ZhiWei ZhiWei { get; set; }
    }
}
