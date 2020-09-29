using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarBrief.Models
{
    public class Player
    {
        public uint Id { get; set; } = 0;
        public uint TeamId { get; set; } = 0;
        public uint ShipId { get; set; } = 0;
        public double Health { get; set; } = 0.0;
        public double MaxHealth { get; set; } = 1.0;
        public double Yaw { get; set; } = 0.0;
        public double Knot { get; set; } = 0.0;
        public bool IsVisible { get; set; } = false;
        public bool IsShipVisible { get; set; } = false;
        public bool IsVehicleBurning { get; set; } = false;
        public bool IsVehicleFlooding { get; set; } = false;

        public void Assign(Player other)
        {
            Id                  = other.Id;
            TeamId              = other.TeamId;
            ShipId              = other.ShipId;
            Health              = other.Health;
            MaxHealth           = other.MaxHealth;
            Yaw                 = other.Yaw;
            Knot                = other.Knot;
            IsVisible           = other.IsVisible;
            IsShipVisible       = other.IsShipVisible;
            IsVehicleBurning    = other.IsVehicleBurning;
            IsVehicleFlooding   = other.IsVehicleFlooding;
        }
    }
}
