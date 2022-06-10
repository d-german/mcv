namespace BmiCalculator.Server.Models;

public record BmiHistory
{
   public string? UserId { get; init; }
   public DateTime? Date { get; init; }
   public double? Bmi { get; init; }
};
