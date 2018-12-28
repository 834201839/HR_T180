namespace MvcMovie.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Departments1 = new HashSet<Department>();
            Users = new HashSet<User>();
            ZhiWeis = new HashSet<ZhiWei>();
            ZhiWeiFaBus = new HashSet<ZhiWeiFaBu>();
        }

        public Guid ID { get; set; }

        [StringLength(20)]
        public string DJianCheng { get; set; }

        [Required]
        [StringLength(40)]
        public string Dname { get; set; }

        public Guid? ParentDepartment { get; set; }

        [Required]
        [StringLength(70)]
        public string Address { get; set; }

        [StringLength(300)]
        public string Dinfo { get; set; }

        [StringLength(300)]
        public string DBeiZhu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments1 { get; set; }

        public virtual Department Department1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZhiWei> ZhiWeis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZhiWeiFaBu> ZhiWeiFaBus { get; set; }
    }
}
