using RoomCalculator.Models;

namespace RoomCalculator.Services;

public class RoomCalculatorService : IRoomCalculatorService
{
    public RoomResult Calculate(RoomDimensions dims)
    {
        var area = dims.Length * dims.Breadth;
        var perimeter = 2 * (dims.Length + dims.Breadth);
        var volume = area * dims.Height;

        return new RoomResult
        {
            Area = area,
            Perimeter = perimeter,
            Volume = volume
        };
    }
}
