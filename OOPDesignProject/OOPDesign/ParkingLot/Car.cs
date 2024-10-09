

namespace OOPDesign.ParkingLot;

public class Car : Vehicle
{
    public Car(string licensePlate)
    {
        _licensePlate = licensePlate;
        _size = ParkingLotEnum.EVehicleSize.Compact;
        _spotNeeded = 3;

    }
    public override bool ParkInSpot(ParkingLot parkingLot, ParkingRequest? req = default)
    {
        req = new ParkingRequest(_licensePlate, _spotNeeded);

        return base.ParkInSpot(parkingLot, req);
    }

    public override void ClearSpot(ParkingLot parkingLot)
    {
        if (_parkingSpot is null)
            return;
        _parkingSpot.LeftParkingLot(parkingLot);
    }
}
