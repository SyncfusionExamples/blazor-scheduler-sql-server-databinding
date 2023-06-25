using Microsoft.EntityFrameworkCore;

namespace SqlServerDataBinding.Data
{
    public class AppointmentDataContext: DbContext
    {
        public AppointmentDataContext(DbContextOptions<AppointmentDataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentData>().HasData(
                new AppointmentData
                {
                    RecordID = 1,
                    Id = 1,
                    Subject = "Meeting",
                    StartTime = new DateTime(2023, 6, 5, 9, 0, 0),
                    EndTime = new DateTime(2023, 6, 5, 10, 30, 0),
                    Location = "Tamilnadu"
                }
            ); 
        }
        public DbSet<AppointmentData> AppointmentDatas { get; set; }
    }
}
