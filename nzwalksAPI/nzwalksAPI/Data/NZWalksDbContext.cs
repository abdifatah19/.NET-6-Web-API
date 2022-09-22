using Microsoft.EntityFrameworkCore;
using nzwalksAPI.Models.Domain;

namespace nzwalksAPI.Data
{
    //make connnection
    //query
    // persist data
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options) : base(options)
        {

        }
        // create regions table in the database if it doesn't exit
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}