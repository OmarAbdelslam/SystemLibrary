namespace System_Library
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Emp_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Emp_Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Emp_Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Emp_Adg { get; set; }

        public int? Emp_Phone { get; set; }

        public int? Emp_Phone_Lind { get; set; }

        public int? Emp_Number_Personalty { get; set; }

        [Column(TypeName = "text")]
        public string Emp_Specilized { get; set; }

        [Column(TypeName = "text")]
        public string Emp_Career { get; set; }

        [StringLength(20)]
        public string Password { get; set; }
    }
}
