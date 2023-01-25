namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Home_Share
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Data_Home_Share()
        {
            Books = new HashSet<Book>();
            Imports = new HashSet<Import>();
        }

        [Key]
        [StringLength(15)]
        public string SH_Num { get; set; }

        [Required]
        [StringLength(30)]
        public string SH_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string SH_City { get; set; }

        [Required]
        [StringLength(30)]
        public string SH_Address { get; set; }

        public int SH_Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string SH_WebSite { get; set; }

        [Required]
        [StringLength(40)]
        public string SH_Emil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book> Books { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }
    }
}
