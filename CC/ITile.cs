using System.Collections.Generic;

namespace CC
{
    public interface ITile
    {
        ITile NeighbourNorth { get; }
        ITile NeighbourEast { get; }
        ITile NeighbourSouth { get; }
        ITile NeighbourWest { get; }
        IOccupant City { get; set; }
        List<IOccupant> Units { get; }
    }
}
