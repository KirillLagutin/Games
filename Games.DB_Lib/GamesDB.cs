using System.IO;
using Games.Model;
using Microsoft.EntityFrameworkCore;

namespace Games.DB_Lib
{
    public class GamesDB : DbContext
    {
        public DbSet<Game> TableGames { get; set; }

        public GamesDB()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(GetConnectionString("connection_to_db.txt"));
        }

        private static string GetConnectionString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}