using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.Model
{
    [Table("tab_games")]
    public class Game
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        [Required]
        public string Name { get; set; }
        
        [Column("company")]
        [Required]
        public string Company { get; set; }
        
        [Column("style")]
        [Required]
        public string Style { get; set; }
        
        [Column("date")]
        [Required]
        public string Date { get; set; }
    }
}