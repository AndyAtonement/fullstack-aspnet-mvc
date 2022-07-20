using BeeEngineering.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeEngineering.Data
{
    public class DataContext : DbContext
    {

        public DbSet<CandidateModel> Candidates { get; set; }  

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
