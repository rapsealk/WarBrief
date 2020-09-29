using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBrief.Models;

namespace WarBrief.Views
{
    public interface IGameView
    {
        void UpdatePlayer(Player player);

        void UpdateOpponent(Player player);
    }
}
