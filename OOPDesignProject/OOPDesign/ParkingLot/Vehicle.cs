
using static OOPDesign.ParkingLot.ParkingLotEnum;

namespace OOPDesign.ParkingLot;

public abstract class Vehicle
{
    protected ParkingSpot? _parkingSpot;

    protected EVehicleSize _size;

    protected string _licensePlate = String.Empty;

    protected int _spotNeeded;



    public virtual bool ParkInSpot(ParkingLot parkingLot, ParkingRequest? req = default)
    {
        if (req is null)
            return false;
        _parkingSpot = parkingLot.ParkVehicle(req);

        return _parkingSpot != null;
    }

    public virtual void ClearSpot(ParkingLot parkingLot)
    {
        if (_parkingSpot is null)
            return;
        _parkingSpot.LeftParkingLot(parkingLot);
    }
}
