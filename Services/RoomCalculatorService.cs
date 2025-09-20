using System;
using RoomCalculator.Models;
namespace RoomCalculator.Services;

public class RoomCalculatorService : IRoomCalculatorService
{
    public RoomResult Calculate(Room room)
    {
        if (room == null)
        {
            throw new ArgumentNullException(nameof(room));
        }

        var area = room.Length * room.Breadth;
        var perimeter = 2 * (room.Length + room.Breadth);
        var volume = room.Length * room.Breadth * room.Height;

        return new RoomResult
        {
            Area = area,
            Perimeter = perimeter,
            Volumen = volume
        };
    }
}
