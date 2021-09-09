﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _Bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set{ _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _Bets; } set { _Bets = value; } }


        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}