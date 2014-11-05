using CC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CCTest
{
    [TestClass]
    public class TestTile
    {
        [TestMethod]
        public void Test_TileNoNeighbours_ReturnsNullNeighbourForAnyDirection()
        {
            ITile testTile = new Tile();
            Assert.IsNull(testTile.NeighbourNorth);
            Assert.IsNull(testTile.NeighbourEast);
            Assert.IsNull(testTile.NeighbourSouth);
            Assert.IsNull(testTile.NeighbourWest);
        }

        [TestMethod]
        public void Test_TileNorthNeighbour_ReturnsNullForAllDirectionsButNorth()
        {
            ITile testTile = new Tile(neighbourNorth:new Tile());
            Assert.IsNotNull(testTile.NeighbourNorth);
            Assert.IsNull(testTile.NeighbourEast);
            Assert.IsNull(testTile.NeighbourSouth);
            Assert.IsNull(testTile.NeighbourWest);
        }

        [TestMethod]
        public void Test_TileNorthNeighbour_ReturnsNullForAllDirectionsButEast()
        {
            ITile testTile = new Tile(neighbourEast: new Tile());
            Assert.IsNotNull(testTile.NeighbourEast);
            Assert.IsNull(testTile.NeighbourNorth);
            Assert.IsNull(testTile.NeighbourSouth);
            Assert.IsNull(testTile.NeighbourWest);
        }

        [TestMethod]
        public void Test_TileNorthNeighbour_ReturnsNullForAllDirectionsButSouth()
        {
            ITile testTile = new Tile(neighbourSouth: new Tile());
            Assert.IsNotNull(testTile.NeighbourSouth);
            Assert.IsNull(testTile.NeighbourEast);
            Assert.IsNull(testTile.NeighbourNorth);
            Assert.IsNull(testTile.NeighbourWest);
        }

        [TestMethod]
        public void Test_TileNorthNeighbour_ReturnsNullForAllDirectionsButWest()
        {
            ITile testTile = new Tile(neighbourWest: new Tile());
            Assert.IsNotNull(testTile.NeighbourWest);
            Assert.IsNull(testTile.NeighbourEast);
            Assert.IsNull(testTile.NeighbourSouth);
            Assert.IsNull(testTile.NeighbourNorth);
        }

        [TestMethod]
        [ExpectedException(typeof())]
        public void Test_ContainsOccupant_AfterSetCity_ThrowErrorIfTryingToAddSecondCity()
        {
            ITile testTile = new Tile();
            City testCity = new City();
            testTile.City = testCity;

        }


        [TestMethod]
        public void Test_ContainsOccupant_AfterSetCityAndAddUnit_ContainsOneCityAndOneUnit()
        { }
    }
}
