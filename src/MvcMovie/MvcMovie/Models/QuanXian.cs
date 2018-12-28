namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuanXian")]
    public partial class QuanXian
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuanXian()
        {
            QuanXian1 = new HashSet<QuanXian>();
            Roleinfoes = new HashSet<Roleinfo>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(30)]
        public string OpenHtml { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public Guid? ParentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanXian> QuanXian1 { get; set; }

        public virtual QuanXian QuanXian2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roleinfo> Roleinfoes { get; set; }
    }
}
