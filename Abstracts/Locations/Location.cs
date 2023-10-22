using System;

namespace BillSystem.Abstracts.Locations
{
    public  class Location
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }

        public Location()
        {
        }

        public Location(int coordX, int coordY)
        {
            CoordX = coordX;
            CoordY = coordY;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   CoordX == location.CoordX &&
                   CoordY == location.CoordY;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CoordX, CoordY);
        }

        public override string ToString()
        {
            return $"{CoordX}, {CoordY}";
        }

        public string ExposeData()
        {
            return $"{CoordX},{CoordY}";
        }
    }
}
