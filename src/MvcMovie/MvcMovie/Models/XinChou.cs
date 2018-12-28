namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XinChou")]
    public partial class XinChou
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XinChou()
        {
            DangAns = new HashSet<DangAn>();
            XinChouDetails = new HashSet<XinChouDetail>();
        }

        public Guid ID { get; set; }

        public int SumPrice { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public Guid? ZhiDingRen { get; set; }

        public Guid? DengJiRen { get; set; }

        public DateTime DengJiDate { get; set; }

        public int State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangAn> DangAns { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XinChouDetail> XinChouDetails { get; set; }
    }
}
