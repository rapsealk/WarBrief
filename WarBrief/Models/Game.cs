using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBrief.Views;

namespace WarBrief.Models
{
    class Game
    {
        private readonly Player player;
        private readonly Player opponent;

        private readonly Queue<Ribbon> ribbons;

        public IGameView View;

        public Game(IGameView view)
        {
            player = new Player();
            opponent = new Player();

            ribbons = new Queue<Ribbon>();

            View = view;
        }

        public void Reset()
        {
            player.Assign(new Player());
            opponent.Assign(new Player());
            ribbons.Clear();
        }

        public void UpdatePlayer(Player newPlayer)
        {
            player.Assign(newPlayer);

            View.UpdatePlayer(newPlayer);
        }

        public void UpdateOpponent(Player newOpponent)
        {
            opponent.Assign(newOpponent);

            View.UpdateOpponent(newOpponent);
        }

        public void EnqueueRibbon(Ribbon ribbon)
        {
            ribbons.Enqueue(ribbon);
        }
    }
}
