using System;
using Games.DB_Lib;
using Games.Model;

namespace Games.App
{
    internal static class Program
    {
        private static void Main()
        {
            var db = new GamesDB();

            foreach (var game in db.TableGames)
            {
                Console.WriteLine($"#{game.Id}: {game.Name} {game.Company} {game.Style} {game.Date}");
            }

            db.TableGames.Add(new Game
            {
                Name = "Stalker 2",
                Company = "GSC",
                Style = "First person shooter",
                Date = "08/12/2022"
            });
            db.SaveChanges();
            
            foreach (var game in db.TableGames)
            {
                Console.WriteLine($"#{game.Id}: {game.Name} {game.Company} {game.Style} {game.Date}");
            }
        }
    }
}