using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarBrief.Models
{
    class Player
    {
        public uint Id { get; set; }
        public uint TeamId { get; set; }
        public uint ShipId { get; set; }
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public double Yaw { get; set; }
        public double Knot { get; set; }
        public bool IsVisible { get; set; }
        public bool IsShipVisible { get; set; }
        public bool IsVehicleBurning { get; set; }
        public bool IsVehicleFlooding { get; set; }
    }
}
