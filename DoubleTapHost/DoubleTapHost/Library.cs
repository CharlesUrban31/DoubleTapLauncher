using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DoubleTapHost
{
    public class Library
    {

        public Library() { }

        public void addGame(Game game)
        {
            // Add Game to database
        }

        public void removeGame(Game game)
        {
            // Remove Game from database
        }

        public Game[] getAllGames()
        {
            return new Game[2]; // Temp Array Return
        }

    }
}
