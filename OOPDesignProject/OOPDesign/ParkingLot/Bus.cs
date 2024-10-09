using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.ParkingLot
{
    public class Bus : Vehicle
    {
        public Bus(string licensePlate)
        {
            _licensePlate = licensePlate;
            _size = ParkingLotEnum.EVehicleSize.Large;
            _spotNeeded = 5;
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
}
