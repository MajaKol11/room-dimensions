using System.ComponentModel.DataAnnotations;

namespace RoomCalculator.Models;

public class RoomDimensions
{
    [Range(0.01, 1000, ErrorMessage = "Length must be greater than 0")]
    public double Length { get; set; }

    [Range(0.01, 1000, ErrorMessage = "Breadth must be greater than 0")]
    public double Breadth { get; set; }

    [Range(0.01, 1000, ErrorMessage = "Height must be greater than 0")]
    public double Height { get; set; } = 2.3; //Default

    public double Area => Length * Breadth;
    public double Perimeter => 2 * (Length + Breadth);
    public double Volume => Length * Breadth * Height;

}
