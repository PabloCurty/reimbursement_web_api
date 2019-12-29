using Microsoft.EntityFrameworkCore;
using reimbursement.Model;

namespace reimbursement.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}
        
        public DbSet<Report> Reports { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Status> Statuses { get; set; }
    }
}