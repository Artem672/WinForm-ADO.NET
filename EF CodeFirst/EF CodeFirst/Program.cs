using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();

            //List<Game> games = new List<Game>()
            //{
            //    new Game()
            //    {
            //        Name = "Need for speed: Most wanted",
            //        Release = new DateTime(2011, 11, 11),
            //        Studio = "EA Black Box",
            //        Style = "Racing"
            //    },
            //    new Game()
            //    {
            //        Name = "World of tanks",
            //        Release = new DateTime(2010, 8, 12),
            //        Studio = "Wargaming",
            //        Style = "Multiplayer"
            //    },
            //    new Game()
            //    {
            //        Name = "Dota 2",
            //        Release = new DateTime(2013, 7, 9),
            //        Studio = "Valve",
            //        Style = "Multiplayer"
            //    }
            //};

            //foreach(var g in games)
            //{
            //    context.games.Add(g);
            //}

            context.SaveChanges();


        }
    }
}
