using System.Collections.Generic;

namespace CC
{
    public class Tile: ITile
    {
        public ITile NeighbourNorth { get; private set; }
        public ITile NeighbourEast { get; private set; }
        public ITile NeighbourSouth { get; private set; }
        public ITile NeighbourWest { get; private set; }
        public IOccupant City
        {
            get { return city; }
            set { city = value; }
        }
        private IOccupant city;
        public List<IOccupant> Units { get; private set; }

        public Tile()
        {
            NeighbourNorth = null;
            NeighbourEast = null;
            NeighbourSouth = null;
            NeighbourWest = null;
            Units = new List<IOccupant>();
            City = null;
        }

        public Tile(ITile neighbourNorth = null, ITile neighbourEast = null,
                    ITile neighbourSouth = null, ITile neighbourWest = null)
        {
            NeighbourNorth = neighbourNorth;
            NeighbourEast = neighbourEast;
            NeighbourSouth = neighbourSouth;
            NeighbourWest = neighbourWest;
            Units = new List<IOccupant>();
            City = null;
        }
    }
}
