namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FanKui")]
    public partial class FanKui
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FanKui()
        {
            PeiXunJiHuas = new HashSet<PeiXunJiHua>();
        }

        public Guid ID { get; set; }

        public int Level { get; set; }

        [Required]
        [StringLength(200)]
        public string ZongJie { get; set; }

        [Required]
        [StringLength(200)]
        public string JieGuo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeiXunJiHua> PeiXunJiHuas { get; set; }
    }
}
