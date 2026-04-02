using API_DesignPartern.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_DesignPartern.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<DongHo> DongHos { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<PhanLoai> PhanLoais { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PhanLoai>(eb =>
            {
                eb.HasKey(x => x.MaPL);
                eb.Property(x => x.MaPL).ValueGeneratedOnAdd(); // identity
                eb.Property(x => x.TenPL).HasMaxLength(500);
            });

            modelBuilder.Entity<ThuongHieu>(eb =>
            {
                eb.HasKey(x => x.MaThuongHieu);
                eb.Property(x => x.MaThuongHieu).ValueGeneratedOnAdd(); // identity
                eb.Property(x => x.TenThuongHieu).HasMaxLength(1000);
                eb.Property(x => x.Logo).HasMaxLength(1000);
                eb.Property(x => x.MoTa).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<NhaCungCap>(eb =>
            {
                eb.HasKey(x => x.MaNCC);
                eb.Property(x => x.MaNCC).ValueGeneratedOnAdd(); // identity
                eb.Property(x => x.TenNCC).HasMaxLength(1000);
                eb.Property(x => x.DiaChi).HasMaxLength(2000);
                eb.Property(x => x.Email).HasMaxLength(500);
                eb.Property(x => x.SDT).HasMaxLength(10);
            });

            // --------------- Phần xử lý cho đồng hồ -----------------

            modelBuilder.Entity<DongHo>(eb =>
            {
                eb.HasKey(x => x.MaDongHo);
                eb.Property(x => x.MaDongHo).ValueGeneratedOnAdd();
                eb.Property(x => x.TenDongHo).HasMaxLength(1000);
                eb.Property(x => x.HinhAnh).HasMaxLength(500);
                eb.Property(x => x.MoTa).HasColumnType("nvarchar(max)");
                eb.Property(x => x.GiaBan).HasColumnType("decimal(18,2)");
                eb.Property(x => x.NgayCapNhat).HasDefaultValueSql("GETDATE()");

                eb.HasOne<PhanLoai>()
                  .WithMany()
                  .HasForeignKey(x => x.MaPL)
                  .OnDelete(DeleteBehavior.Cascade);

                eb.HasOne<ThuongHieu>()
                  .WithMany()
                  .HasForeignKey(x => x.MaThuongHieu)
                  .OnDelete(DeleteBehavior.Cascade);

                eb.HasOne<NhaCungCap>()
                  .WithMany()
                  .HasForeignKey(x => x.MaNCC)
                  .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
