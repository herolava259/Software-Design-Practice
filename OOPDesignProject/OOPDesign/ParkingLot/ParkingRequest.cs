using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.ParkingLot;

public class ParkingRequest
{
    public ParkingRequest(string licensePlate, int neededSlot)
    {
        LicensePlate = licensePlate;
        NeededSlot = neededSlot;
    }
    public string LicensePlate { get; private init; }

    public int NeededSlot { get; private init; }
}
