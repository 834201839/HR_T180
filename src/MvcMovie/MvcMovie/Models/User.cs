namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            DangAns = new HashSet<DangAn>();
            MianShis = new HashSet<MianShi>();
            MianShis1 = new HashSet<MianShi>();
            MianShis2 = new HashSet<MianShi>();
            ShenHes = new HashSet<ShenHe>();
            ShenHeRens = new HashSet<ShenHeRen>();
            ShiTis = new HashSet<ShiTi>();
            XinChous = new HashSet<XinChou>();
            XinChous1 = new HashSet<XinChou>();
            ZhiWeiFaBus = new HashSet<ZhiWeiFaBu>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(60)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string PassWord { get; set; }

        public Guid RID { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        public Guid DID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangAn> DangAns { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MianShi> MianShis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MianShi> MianShis1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MianShi> MianShis2 { get; set; }

        public virtual Roleinfo Roleinfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShenHe> ShenHes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShenHeRen> ShenHeRens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiTi> ShiTis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XinChou> XinChous { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XinChou> XinChous1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZhiWeiFaBu> ZhiWeiFaBus { get; set; }
    }
}
