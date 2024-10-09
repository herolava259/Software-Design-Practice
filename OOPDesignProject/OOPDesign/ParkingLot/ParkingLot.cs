

namespace OOPDesign.ParkingLot;

public class ParkingLot
{
    
    private readonly Guid[,] _dataGrid;


    private readonly Dictionary<Guid, ParkingSpot> spotDict = new();
    
    public ParkingLot(int rowSize,
                      int colSize)
    {
        
        _dataGrid = new Guid[rowSize, colSize];
        RowSize = rowSize;
        ColSize = colSize;
    }

    public bool IsAvailable
    {
        get { 
            for(int i = 0; i < RowSize; ++i)
            {
                for(int j=0; j < ColSize; ++j)
                {
                    if (_dataGrid[i, j] != Guid.Empty)
                        return true;
                }
            }

            return false;
        }
    }

    public int RowSize { get; }
    public int ColSize { get; }

    public ParkingSpot? ParkVehicle(ParkingRequest req)
    {
        
        var (rowPos, colPos) = FindAvailableSpot(req.NeededSlot);

        if (colPos < 0 || rowPos < 0) return default;

        var newTicket = Guid.NewGuid();

        for(int i = 0; i < req.NeededSlot; i++)
        {
            _dataGrid[rowPos, colPos + i] = newTicket;
        }
        spotDict[newTicket] = new ParkingSpot(req.LicensePlate, newTicket, req.NeededSlot, rowPos, colPos);

        return spotDict[newTicket];
    }

    public bool CancelTicket(Guid ticketId)
    {
        if (!spotDict.TryGetValue(ticketId, out var spot))
            return false;

        spotDict.Remove(ticketId);
        for(int i = 0; i < spot.NoOfSpots; ++i)
        {
            _dataGrid[spot.PositionRow, spot.PositionCol + i] = Guid.Empty;
        }

        return true;
    }

    private (int, int) FindAvailableSpot(int noOfSpots)
    {
        for(int i = 0; i < RowSize; ++i)
        {
            for(int j =0; i< ColSize; ++j)
            {
                if (_dataGrid[i, j] != Guid.Empty)
                    continue;
                if (j + noOfSpots >= ColSize)
                    break;
                int tmpSpot = 0;

                while(tmpSpot < noOfSpots && j + tmpSpot < ColSize && _dataGrid[i, j+tmpSpot] == Guid.Empty)
                {
                    tmpSpot++;
                }

                if(tmpSpot == noOfSpots)
                {
                    return (i, j);
                }

            }
        }

        return (-1, -1);
    }
}
