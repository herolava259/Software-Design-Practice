

namespace OOPDesign.ParkingLot;

public class MultipleLevelParking
{
    private readonly int _noOfLevel;
    private readonly List<ParkingLot> parkingLots = new List<ParkingLot>();

    public MultipleLevelParking(int level)
    {
        this._noOfLevel = level;
    }

    public bool ParkVehicle(Vehicle v)
    {
        return false;
    }
}
