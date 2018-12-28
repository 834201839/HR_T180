namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MianShi")]
    public partial class MianShi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MianShi()
        {
            JianLis = new HashSet<JianLi>();
        }

        public Guid ID { get; set; }

        public Guid YiUID { get; set; }

        public DateTime YiDate { get; set; }

        [Required]
        [StringLength(200)]
        public string YiComment { get; set; }

        public Guid ErUID { get; set; }

        public DateTime ErDate { get; set; }

        [Required]
        [StringLength(200)]
        public string ErComment { get; set; }

        public Guid SanUID { get; set; }

        public DateTime SanDate { get; set; }

        [Required]
        [StringLength(200)]
        public string SanComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JianLi> JianLis { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }

        public virtual User User2 { get; set; }
    }
}
