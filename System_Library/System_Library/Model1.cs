namespace System_Library
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Data_Authoers> Data_Authoers { get; set; }
        public virtual DbSet<Data_Home_Share> Data_Home_Share { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<Metaphor> Metaphors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Specilized_Book> Specilized_Book { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.B_Num_National)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_As2ra)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_Buy)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_Salary)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_Location_Liba)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_Num_Location_Liba)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.B_Type_Printer)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Ho_Sh_Num)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Metaphors)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.B_Num);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Adg)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.E_mill)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Authoers>()
                .Property(e => e.A_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Authoers>()
                .Property(e => e.A_Emil)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .Property(e => e.SH_Num)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .Property(e => e.SH_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .Property(e => e.SH_City)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .Property(e => e.SH_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .Property(e => e.SH_Emil)
                .IsUnicode(false);

            modelBuilder.Entity<Data_Home_Share>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Data_Home_Share)
                .HasForeignKey(e => e.Ho_Sh_Num);

            modelBuilder.Entity<Data_Home_Share>()
                .HasMany(e => e.Imports)
                .WithOptional(e => e.Data_Home_Share)
                .HasForeignKey(e => e.Home_Share_ID);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Emp_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Emp_Adg)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Emp_Specilized)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Emp_Career)
                .IsUnicode(false);

            modelBuilder.Entity<Employe>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .Property(e => e.Home_Share_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .HasMany(e => e.Imports1)
                .WithOptional(e => e.Import1)
                .HasForeignKey(e => e.Supp_ID);

            modelBuilder.Entity<Metaphor>()
                .Property(e => e.C_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Metaphor>()
                .Property(e => e.C_BorrowingPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.O_Price)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.O_Descount)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Specilized_Book>()
                .Property(e => e.S_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Specilized_Book>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Specilized_Book)
                .HasForeignKey(e => e.Specilized_ID_FK);

            modelBuilder.Entity<Student>()
                .Property(e => e.S_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.S_Section)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.S_Team)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Sub_Period)
                .IsUnicode(false);

            modelBuilder.Entity<Subscription>()
                .Property(e => e.Price)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Adg)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Addrees)
                .IsUnicode(false);
        }
    }
}
