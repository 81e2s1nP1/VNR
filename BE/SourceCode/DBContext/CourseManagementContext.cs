using SourceCode.KhoaHocModel;
using SourceCode.MonHocModel;
using Microsoft.EntityFrameworkCore;

namespace SourceCode.DBContext
{
    public class CourseManagementContext : DbContext
    {
        public CourseManagementContext(DbContextOptions<CourseManagementContext> options) : base(options)
        {
        }

        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>()
                .HasOne(m => m.KhoaHoc)
                .WithMany(k => k.MonHocs)
                .HasForeignKey(m => m.KhoaHocID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
