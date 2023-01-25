namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Phone { get; set; }

        [Column(TypeName = "text")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Gender { get; set; }

        [StringLength(10)]
        public string Adg { get; set; }

        [StringLength(50)]
        public string E_mill { get; set; }

        [StringLength(50)]
        public string Country { get; set; }
    }
}
