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
        public virtual DbSet<CodeVoucher> CodeVouchers { get; set; }
        public virtual DbSet<DetailAdvanceSalary> DetailAdvanceSalaries { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<HeSoTinhLuong> HeSoTinhLuongs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MoMo> MoMos { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionDetail> PermissionDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RatePoint> RatePoints { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SheetDetail> SheetDetails { get; set; }
        public virtual DbSet<SubDetail> SubDetails { get; set; }
        public virtual DbSet<SubSalary> SubSalaries { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<WorkSheet> WorkSheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=MiniStore;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BillOrder>(entity =>
            {
                entity.HasKey(e => e.IdBillOrder)
                    .HasName("PK__BillOrde__58724C24A956A2F8");

                entity.Property(e => e.IdBillOrder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBill).HasColumnType("date");

                entity.Property(e => e.DiscountPrice).HasColumnName("Discount_Price");

                entity.Property(e => e.IdVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneMember).HasMaxLength(20);

                entity.HasOne(d => d.DateOfBillNavigation)
                    .WithMany(p => p.BillOrders)
                    .HasForeignKey(d => d.DateOfBill)
                    .HasConstraintName("FK__BillOrder__DateO__619B8048");

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.BillOrders)
                    .HasForeignKey(d => d.IdVoucher)
                    .HasConstraintName("FK__BillOrder__IdVou__628FA481");

                entity.HasOne(d => d.PhoneMemberNavigation)
                    .WithMany(p => p.BillOrders)
                    .HasForeignKey(d => d.PhoneMember)
                    .HasConstraintName("FK__BillOrder__Phone__6383C8BA");
            });

            modelBuilder.Entity<Catalogy>(entity =>
            {
                entity.HasKey(e => e.ProductType)
                    .HasName("PK__Catalogy__B181B0A5B5D7475B");

                entity.ToTable("Catalogy");

                entity.Property(e => e.ProductType).HasMaxLength(10);
            });

            modelBuilder.Entity<CodeVoucher>(entity =>
            {
                entity.ToTable("CodeVoucher");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.IdVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityValue).HasColumnName("quantity_value");

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.CodeVouchers)
                    .HasForeignKey(d => d.IdVoucher)
                    .HasConstraintName("FK__CodeVouch__IdVou__6477ECF3");
            });

            modelBuilder.Entity<DetailAdvanceSalary>(entity =>
            {
                entity.HasKey(e => e.IdAdvanceSalary)
                    .HasName("PK__DetailAd__8FF8B63606FE3F73");

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
                    .HasConstraintName("FK__DetailAdv__IdEmp__44FF419A");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmp)
                    .HasName("PK__Employee__0F23D647B79AEEE5");

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

                entity.Property(e => e.Snpt).HasColumnName("SNPT");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK_emp_per");
            });

            modelBuilder.Entity<HeSoTinhLuong>(entity =>
            {
                entity.ToTable("HeSoTinhLuong");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Bhtn).HasColumnName("bhtn");

                entity.Property(e => e.Bhxh).HasColumnName("bhxh");

                entity.Property(e => e.Bhyt).HasColumnName("bhyt");

                entity.Property(e => e.GtgcBanthan).HasColumnName("gtgc_banthan");

                entity.Property(e => e.GtgcNpt).HasColumnName("gtgc_npt");

                entity.Property(e => e.LuongToiThieu).HasColumnName("luong_toi_thieu");

                entity.Property(e => e.MucBhToiDa).HasColumnName("muc_bh_toi_da");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.PhoneMember)
                    .HasName("PK__Member__57790E2598C9BB09");

                entity.ToTable("Member");

                entity.Property(e => e.PhoneMember).HasMaxLength(20);

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdRate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Rate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCreate).HasColumnType("datetime");

                entity.HasOne(d => d.IdRateNavigation)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.IdRate)
                    .HasConstraintName("FK__Member__Id_Rate__6754599E");
            });

            modelBuilder.Entity<MoMo>(entity =>
            {
                entity.ToTable("MoMo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Gmail)
                    .HasMaxLength(100)
                    .HasColumnName("gmail");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("PK__Orders__C38F3009C555FB7D");

                entity.Property(e => e.IdOrder).HasMaxLength(20);

                entity.Property(e => e.DateOrders)
                    .HasColumnType("datetime")
                    .HasColumnName("dateOrders");

                entity.Property(e => e.IdBillOrder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.IdUnit)
                    .HasMaxLength(20)
                    .HasColumnName("ID_Unit");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdBillOrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdBillOrder)
                    .HasConstraintName("FK__Orders__IdBillOr__693CA210");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__Orders__IdEmp__47DBAE45");

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdUnit)
                    .HasConstraintName("FK__Orders__ID_Unit__68487DD7");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.Roles)
                    .HasName("PK__Permissi__F92229BDAFF35705");

                entity.ToTable("Permission");

                entity.Property(e => e.Roles).ValueGeneratedNever();

                entity.Property(e => e.Permission1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Permission");
            });

            modelBuilder.Entity<PermissionDetail>(entity =>
            {
                entity.ToTable("PermissionDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("action_code");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(20)
                    .HasColumnName("action_name");

                entity.Property(e => e.CheckAction).HasColumnName("check_action");

                entity.Property(e => e.IdPer).HasColumnName("id_per");

                entity.HasOne(d => d.IdPerNavigation)
                    .WithMany(p => p.PermissionDetails)
                    .HasForeignKey(d => d.IdPer)
                    .HasConstraintName("FK__Permissio__id_pe__6B24EA82");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Sku)
                    .HasName("PK__Product__CA1ECF0CE8F09492");

                entity.ToTable("Product");

                entity.Property(e => e.Sku)
                    .HasMaxLength(20)
                    .HasColumnName("SKU");

                entity.Property(e => e.DateImport)
                    .HasColumnType("date")
                    .HasColumnName("Date_Import");

                entity.Property(e => e.Exp)
                    .HasColumnType("date")
                    .HasColumnName("EXP");

                entity.Property(e => e.IdSupplier)
                    .HasMaxLength(20)
                    .HasColumnName("ID_supplier");

                entity.Property(e => e.Mfg)
                    .HasColumnType("date")
                    .HasColumnName("MFG");

                entity.Property(e => e.NameProduct).HasMaxLength(50);

                entity.Property(e => e.ProductType).HasMaxLength(10);

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("ID_supplier");

                entity.HasOne(d => d.ProductTypeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductType)
                    .HasConstraintName("FK__Product__Product__3F466844");
            });

            modelBuilder.Entity<RatePoint>(entity =>
            {
                entity.HasKey(e => e.IdRate)
                    .HasName("PK__RatePoin__36C784F6F9F51C94");

                entity.ToTable("RatePoint");

                entity.Property(e => e.IdRate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Id_Rate");

                entity.Property(e => e.RateTaking).HasColumnName("Rate_Taking");

                entity.Property(e => e.RateUsing).HasColumnName("Rate_Using");

                entity.Property(e => e.StatusRp).HasColumnName("StatusRP");
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.HasKey(e => e.DateRevenue)
                    .HasName("PK__Revenue__D0CEC0D99DD37913");

                entity.ToTable("Revenue");

                entity.Property(e => e.DateRevenue).HasColumnType("date");
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.IdSalary)
                    .HasName("PK__Salary__4304AC9C3434BE90");

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
                    .HasConstraintName("FK__Salary__IdEmp__4CA06362");
            });

            modelBuilder.Entity<SheetDetail>(entity =>
            {
                entity.HasKey(e => e.Sheet)
                    .HasName("PK__SheetDet__089E60E775AA8844");

                entity.ToTable("SheetDetail");

                entity.Property(e => e.Sheet).ValueGeneratedNever();

                entity.Property(e => e.ShiftEndTime).HasColumnType("time(0)");

                entity.Property(e => e.ShiftStartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.RolesNavigation)
                    .WithMany(p => p.SheetDetails)
                    .HasForeignKey(d => d.Roles)
                    .HasConstraintName("FK__SheetDeta__Roles__6EF57B66");
            });

            modelBuilder.Entity<SubDetail>(entity =>
            {
                entity.HasKey(e => e.IdDetail)
                    .HasName("PK__SubDetai__75EC3C06F558D31F");

                entity.ToTable("SubDetail");

                entity.Property(e => e.IdDetail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idDetail");

                entity.Property(e => e.Check).HasColumnName("check");

                entity.Property(e => e.IdEmp)
                    .HasMaxLength(20)
                    .HasColumnName("idEmp");

                entity.Property(e => e.IdSub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSub");

                entity.Property(e => e.TimeBegin).HasColumnType("date");

                entity.Property(e => e.TimeEnd).HasColumnType("date");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.SubDetails)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__SubDetail__idEmp__6FE99F9F");

                entity.HasOne(d => d.IdSubNavigation)
                    .WithMany(p => p.SubDetails)
                    .HasForeignKey(d => d.IdSub)
                    .HasConstraintName("FK__SubDetail__idSub__5DCAEF64");
            });

            modelBuilder.Entity<SubSalary>(entity =>
            {
                entity.HasKey(e => e.IdSub)
                    .HasName("PK__SubSalar__024F281BDD8164D2");

                entity.ToTable("SubSalary");

                entity.Property(e => e.IdSub)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idSub");

                entity.Property(e => e.Describe)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.TimeBegin).HasColumnType("date");

                entity.Property(e => e.TimeEnd).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.IdSupplier)
                    .HasName("PK__Supplier__3A342CE31C0034FF");

                entity.ToTable("Supplier");

                entity.Property(e => e.IdSupplier)
                    .HasMaxLength(20)
                    .HasColumnName("ID_supplier");

                entity.Property(e => e.AddressSupplier)
                    .HasMaxLength(200)
                    .HasColumnName("Address_supplier");

                entity.Property(e => e.NameSupplier)
                    .HasMaxLength(50)
                    .HasColumnName("Name_supplier");

                entity.Property(e => e.Note).HasMaxLength(100);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.IdUnit)
                    .HasName("PK__unit__EB4517D38C500338");

                entity.ToTable("unit");

                entity.Property(e => e.IdUnit)
                    .HasMaxLength(20)
                    .HasColumnName("ID_Unit");

                entity.Property(e => e.QuantityUnit).HasColumnName("Quantity_Unit");

                entity.Property(e => e.Sku)
                    .HasMaxLength(20)
                    .HasColumnName("SKU");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(15)
                    .HasColumnName("Unit_Name");

                entity.HasOne(d => d.SkuNavigation)
                    .WithMany(p => p.Units)
                    .HasForeignKey(d => d.Sku)
                    .HasConstraintName("FK__unit__SKU__71D1E811");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.IdVoucher)
                    .HasName("PK__Voucher__329D557EF16D2982");

                entity.ToTable("Voucher");

                entity.Property(e => e.IdVoucher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Conditions).HasColumnName("conditions");

                entity.Property(e => e.Exp)
                    .HasColumnType("date")
                    .HasColumnName("EXP");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkSheet>(entity =>
            {
                entity.HasKey(e => e.IdWorkSheet)
                    .HasName("PK__WorkShee__AB7595E84E29FAA9");

                entity.ToTable("WorkSheet");

                entity.Property(e => e.IdWorkSheet).HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DefaultCoefficient).HasColumnName("default_coefficient");

                entity.Property(e => e.IdEmp).HasMaxLength(20);

                entity.Property(e => e.SundayCoefficient).HasColumnName("sunday_coefficient");

                entity.Property(e => e.TimeCheckIn).HasColumnType("datetime");

                entity.Property(e => e.TimeCheckOut).HasColumnType("datetime");

                entity.Property(e => e.TotalWorkingHours).HasColumnName("Total_working_hours");

                entity.HasOne(d => d.IdEmpNavigation)
                    .WithMany(p => p.WorkSheets)
                    .HasForeignKey(d => d.IdEmp)
                    .HasConstraintName("FK__WorkSheet__IdEmp__4F7CD00D");

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
