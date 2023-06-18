using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Repository.Models
{
    public partial class MiniStoreContext : DbContext
    {
        public MiniStoreContext()
        {
        }

        public MiniStoreContext(DbContextOptions<MiniStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BillOrder> BillOrders { get; set; }
        public virtual DbSet<Catalogy> Catalogies { get; set; }
        public virtual DbSet<DetailAdvanceSalary> DetailAdvanceSalaries { get; set; }
        public virtual DbSet<DetailSubSalary> DetailSubSalaries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SheetDetail> SheetDetails { get; set; }
        public virtual DbSet<SubSalary> SubSalaries { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<WorkSheet> WorkSheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=26.198.132.171;uid=sa;pwd=12345;database=MiniStore;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BillOrder>(entity =>
            {
                entity.HasKey(e => e.IdBillOrder)
                    .HasName("PK__BillOrde__58724C241655E169");

                entity.Property(e => e.IdBillOrder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBill).HasColumnType("date");

                entity.HasOne(d => d.DateOfBillNavigation)
                    .WithMany(p => p.BillOrders)
                    .HasForeignKey(d => d.DateOfBill)
                    .HasConstraintName("FK__BillOrder__DateO__534D60F1");
            });

            modelBuilder.Entity<Catalogy>(entity =>
            {
                entity.HasKey(e => e.ProductType)
                    .HasName("PK__Catalogy__B181B0A5B5D7475B");

                entity.ToTable("Catalogy");

                entity.Property(e => e.ProductType).HasMaxLength(10);
            });

            modelBuilder.Entity<DetailAdvanceSalary>(entity =>
            {
                entity.HasKey(e => e.IdAdvanceSalary)
                    .HasName("PK__DetailAd__8FF8B63629F06BA9");

                entity.ToTable("DetailAdvanceSalary");

                entity.Property(e => e.IdAdvanceSalary).HasMaxLength(10);

                entity.Property(e => e.DateAs)
                    .HasColumnType("date")
                    .HasColumnName("DateAS");

                entity.Property(e => e.DescriptionA).HasMaxLength(60);

                entity.Property(e => e.IdEmp)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.DetailAdvanceSalaries)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetailAdv__IdEmp__5441852A");
            });

            modelBuilder.Entity<DetailSubSalary>(entity =>
            {
                entity.HasKey(e => e.IdDetailSubSalary)
                    .HasName("PK__DetailSu__38029D0F49CD70B0");

                entity.ToTable("DetailSubSalary");

                entity.Property(e => e.IdDetailSubSalary).HasMaxLength(10);

                entity.Property(e => e.DescriptionA).HasMaxLength(60);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmp)
                    .HasName("PK__Employee__0F23D6475A87569E");

                entity.ToTable("Employee");

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.AddressEmp).HasMaxLength(250);

                entity.Property(e => e.Cccd)
                    .HasMaxLength(50)
                    .HasColumnName("CCCD");

                entity.Property(e => e.DateJoin).HasColumnType("date");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.FullNameEmp).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneEmp).HasMaxLength(15);

                entity.Property(e => e.Roles)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK__Employee__Roles__32E0915F");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.PhoneMember)
                    .HasName("PK__Member__57790E254162C2A0");

                entity.ToTable("Member");

                entity.Property(e => e.PhoneMember).HasMaxLength(20);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("PK__Orders__C38F300941BBFCFC");

                entity.Property(e => e.IdOrder).HasMaxLength(20);

                entity.Property(e => e.DateOrders)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOrders");

                entity.Property(e => e.IdBillOrder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.IdVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameProduct).HasMaxLength(50);

                entity.Property(e => e.PhoneMember).HasMaxLength(20);

                entity.Property(e => e.Sku)
                    .HasMaxLength(20)
                    .HasColumnName("SKU");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdBillOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdBillOrder)
                    .HasConstraintName("FK__Orders__IdBillOr__5629CD9C");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__Orders__IdEmp__571DF1D5");

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdVoucher)
                    .HasConstraintName("FK__Orders__IdVouche__5812160E");

                entity.HasOne(d => d.PhoneMemberNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.PhoneMember)
                    .HasConstraintName("FK__Orders__PhoneMem__59063A47");

                entity.HasOne(d => d.SkuNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Sku)
                    .HasConstraintName("FK__Orders__SKU__59FA5E80");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Roles)
                    .HasName("PK__Permissi__F92229BDAFF35705");

                entity.ToTable("Permission");

                entity.Property(e => e.Roles)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Permission1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Permission");

                entity.Property(e => e.Tax).HasColumnName("tax");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .HasName("PK__Product__CA1ECF0CE8F09492");

                entity.ToTable("Product");

                entity.Property(e => e.Sku)
                    .HasMaxLength(20)
                    .HasColumnName("SKU");

                entity.Property(e => e.Exp)
                    .HasColumnType("date")
                    .HasColumnName("EXP");

                entity.Property(e => e.Mfg)
                    .HasColumnType("date")
                    .HasColumnName("MFG");

                entity.Property(e => e.NameProduct).HasMaxLength(50);

                entity.Property(e => e.ProductType).HasMaxLength(10);

                entity.HasOne(d => d.ProductTypeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductType)
                    .HasConstraintName("FK__Product__Product__3F466844");
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.HasKey(e => e.DateRevenue)
                    .HasName("PK__Revenue__D0CEC0D9CB0B753A");

                entity.ToTable("Revenue");

                entity.Property(e => e.DateRevenue).HasColumnType("date");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.IdSalary)
                    .HasName("PK__Salary__4304AC9C5D75E393");

                entity.ToTable("Salary");

                entity.Property(e => e.IdSalary).HasMaxLength(20);

                entity.Property(e => e.DateImonth).HasColumnType("date");

                entity.Property(e => e.DateOmonth).HasColumnType("date");

                entity.Property(e => e.IdEmp)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Salaries)
                    .HasForeignKey(d => d.IdEmp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Salary__IdEmp__5BE2A6F2");
            });

            modelBuilder.Entity<SheetDetail>(entity =>
            {
                entity.HasKey(e => e.Sheet)
                    .HasName("PK__SheetDet__089E60E775AA8844");

                entity.ToTable("SheetDetail");

                entity.Property(e => e.Sheet).ValueGeneratedNever();

                entity.Property(e => e.DescriptionS).HasMaxLength(50);

                entity.Property(e => e.ShiftEndTime).HasMaxLength(50);

                entity.Property(e => e.ShiftStartTime).HasMaxLength(50);
            });

            modelBuilder.Entity<SubSalary>(entity =>
            {
                entity.HasKey(e => e.IdSubSalary)
                    .HasName("PK__SubSalar__4D7A054D35774EB4");

                entity.ToTable("SubSalary");

                entity.Property(e => e.IdSubSalary).HasMaxLength(20);

                entity.Property(e => e.IdDetailSubSalary).HasMaxLength(10);

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.Time).HasColumnType("date");

                entity.HasOne(d => d.IdDetailSubSalaryNavigation)
                    .WithMany(p => p.SubSalaries)
                    .HasForeignKey(d => d.IdDetailSubSalary)
                    .HasConstraintName("FK__SubSalary__IdDet__5CD6CB2B");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.SubSalaries)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__SubSalary__IdEmp__5DCAEF64");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.IdVoucher)
                    .HasName("PK__Voucher__329D557EA6CF3D4B");

                entity.ToTable("Voucher");

                entity.Property(e => e.IdVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Exp)
                    .HasColumnType("date")
                    .HasColumnName("EXP");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkSheet>(entity =>
            {
                entity.HasKey(e => e.IdWorkSheet)
                    .HasName("PK__WorkShee__AB7595E8C15E530C");

                entity.ToTable("WorkSheet");

                entity.Property(e => e.IdWorkSheet).HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.TimeCheckIn).HasColumnType("datetime");

                entity.Property(e => e.TimeCheckOut).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.WorkSheets)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__WorkSheet__IdEmp__5EBF139D");

                entity.HasOne(d => d.SheetNavigation)
                    .WithMany(p => p.WorkSheets)
                    .HasForeignKey(d => d.Sheet)
                    .HasConstraintName("FK__WorkSheet__Sheet__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
