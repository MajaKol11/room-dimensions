using RoomCalculator.Models;

namespace RoomCalculator.Services;

public interface IRoomCalculatorService
{
    RoomResult Calculate(RoomDimensions dims);
}
