using Microsoft.EntityFrameworkCore;
using ResumeAPI.Data.Models;

namespace ResumeAPI.Data.Context
{
    public class ResumeAPIContext : DbContext
    {
        public ResumeAPIContext(DbContextOptions<ResumeAPIContext> options) : base(options) 
        {
        
        }

        public DbSet<Skills> Skills { get; set; }
    }
}
