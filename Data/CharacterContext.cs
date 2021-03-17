using CharacterManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterManager.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Character");
        }
    }
}