namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Import
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Import()
        {
            Imports1 = new HashSet<Import>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }

        public int? Num_Copy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Chapter { get; set; }

        [StringLength(15)]
        public string Home_Share_ID { get; set; }

        public int? Supp_ID { get; set; }

        public virtual Data_Home_Share Data_Home_Share { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports1 { get; set; }

        public virtual Import Import1 { get; set; }
    }
}
