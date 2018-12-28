namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Roleinfo")]
    public partial class Roleinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roleinfo()
        {
            Roleinfo1 = new HashSet<Roleinfo>();
            Users = new HashSet<User>();
            QuanXians = new HashSet<QuanXian>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(60)]
        public string Rolename { get; set; }

        public Guid? ParentRole { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Roleinfo> Roleinfo1 { get; set; }

        public virtual Roleinfo Roleinfo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuanXian> QuanXians { get; set; }
    }
}
