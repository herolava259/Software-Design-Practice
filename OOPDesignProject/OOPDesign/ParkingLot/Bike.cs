using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPDesign.ParkingLot.ParkingLotEnum;

namespace OOPDesign.ParkingLot;

public class Bike : Vehicle
{
    public Bike(string licensePalate)
    {
        _licensePlate = licensePalate;
        _size = EVehicleSize.Small;
        _spotNeeded = 1;
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
