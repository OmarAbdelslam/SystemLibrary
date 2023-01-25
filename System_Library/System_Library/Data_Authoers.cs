namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Authoers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int A_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string A_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string A_Country { get; set; }

        [Required]
        [StringLength(20)]
        public string A_Address { get; set; }

        public int A_Phone { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string A_WebSite { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string A_Emil { get; set; }
    }
}
