namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZhiWei")]
    public partial class ZhiWei
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZhiWei()
        {
            DangAns = new HashSet<DangAn>();
            JianLis = new HashSet<JianLi>();
            ZhiWeiFaBus = new HashSet<ZhiWeiFaBu>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ZName { get; set; }

        public Guid? ZWFLID { get; set; }

        public Guid? DID { get; set; }

        [StringLength(80)]
        public string Zinfo { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangAn> DangAns { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JianLi> JianLis { get; set; }

        public virtual ZhiWeiFenLei ZhiWeiFenLei { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZhiWeiFaBu> ZhiWeiFaBus { get; set; }
    }
}
