

using static OOPDesign.ParkingLot.ParkingLotEnum;

namespace OOPDesign.ParkingLot;

public class ParkingSpot
{
    private readonly Guid ticketId;

    public string LicensePlate { get; }
    
    public int NoOfSpots { get; }
    public int PositionRow { get; }
    public int PositionCol { get; }

    public ParkingSpot(string licensePlate,
                       Guid ticketId,
                       int noOfSpots,
                       int positionRow,
                       int positionCol)
    {
        LicensePlate = licensePlate;
        this.ticketId = ticketId;
        NoOfSpots = noOfSpots;
        PositionRow = positionRow;
        PositionCol = positionCol;
    }

    public void LeftParkingLot(ParkingLot parkingLot)
    {
        parkingLot.CancelTicket(ticketId);
    }
    
}
