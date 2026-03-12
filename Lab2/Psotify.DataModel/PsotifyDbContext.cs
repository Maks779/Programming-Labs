using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Psotify.DataModel
{
    public class PsotifyDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Psotify.db");
        }
    }

    public class Song
    {
        public int SongId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string Length { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
