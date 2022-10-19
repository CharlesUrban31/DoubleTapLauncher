using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleTapHost
{
    public class Game
    {

        public string gameName { get; set; }
        public string gamePath { get; set; }
        public string gameDesc { get; set; }
        public string categoryOne { get; set; }
        public string categoryTwo { get; set; }
        public string categoryThree { get; set; }


        public Game(string _name, string _path, string _desc, string _catOne, string _catTwo, string _catThree)
        {
            gameName = _name;
            gamePath = _path;
            gameDesc = _desc;
            categoryOne = _catOne;
            categoryTwo = _catTwo;
            categoryThree = _catThree;
        }

    }
}
