namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZhiWeiFenLei")]
    public partial class ZhiWeiFenLei
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZhiWeiFenLei()
        {
            ZhiWeis = new HashSet<ZhiWei>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(60)]
        public string ZWFLName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZhiWei> ZhiWeis { get; set; }
    }
}
