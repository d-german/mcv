using BmiCalculator.Server.Models;

namespace BmiCalculator.Server;

public interface IBmiRepository
{
    Task<IEnumerable<BmiHistory>?> GetBmiHistoryAsync(string userId);
    Task<BmiHistory?> SaveBmiHistoryAsync(BmiHistory bmiHistory);
}