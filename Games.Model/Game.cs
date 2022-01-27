using System;

namespace Games.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Style { get; set; }
        public DateTime Date { get; set; }
    }
}