namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XinChouXiangMu")]
    public partial class XinChouXiangMu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XinChouXiangMu()
        {
            XinChouDetails = new HashSet<XinChouDetail>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(40)]
        public string XMName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XinChouDetail> XinChouDetails { get; set; }
    }
}
