using BmiCalculator.Server.Models;

namespace BmiCalculator.Server;

public class BmiRepository : IBmiRepository
{
    private readonly List<BmiHistory> _bmiHistory = new()
    {
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 1),
            Bmi = 20.0
          
        },
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 2),
            Bmi = 20.0
        },
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 3),
            Bmi = 19.9
        },
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 4),
            Bmi = 19.9
        },
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 5),
            Bmi = 19.9
        },
        new BmiHistory
        {
            UserId = "1",
            Date = new DateTime(2020, 1, 6),
            Bmi = 19.9
        },
        
    };

    public Task<IEnumerable<BmiHistory>?> GetBmiHistoryAsync(string userId)
    {
        return Task.Run(() => _bmiHistory.Where(x => x.UserId == userId))!;
    }

    public Task<BmiHistory?> SaveBmiHistoryAsync(BmiHistory bmiHistory)
    {
        return Task.Run(() =>
        {
            _bmiHistory.Add(bmiHistory);
            return bmiHistory;
        })!;
       
    }
}
