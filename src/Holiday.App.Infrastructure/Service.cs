using Holiday.App.Infrastructure.Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Holiday.App.Infrastructure;

public class Service : IService
{

    public List<Domain.Entities.Holiday> CalculateHolidayByYear(int year)
    {
        if(year < 0)
        {
            throw new ArgumentException("year must be positive.", nameof(year));
        }

        var easter = CalculateEaster(year);
        var corpusChristi = easter.AddDays(60);
        var dead = new DateOnly(year, 11, 2);
        var christmas = new DateOnly(year, 12, 25);

        return
        [
            Domain.Entities.Holiday.Create(Guid.NewGuid(), easter, Domain.Entities.HolidaysName.Easter),
            Domain.Entities.Holiday.Create(Guid.NewGuid(), corpusChristi, Domain.Entities.HolidaysName.CorpusChristi),
            Domain.Entities.Holiday.Create(Guid.NewGuid(), dead, Domain.Entities.HolidaysName.Dead),
            Domain.Entities.Holiday.Create(Guid.NewGuid(), christmas, Domain.Entities.HolidaysName.Christmas)
        ];
    }

    private DateOnly CalculateEaster(int year)
    {
        int a = year % 19;
        int b = year / 100;
        int c = year % 100;
        int d = b / 4;
        int e = b % 4;
        int f = (b + 8) / 25;
        int g = (b - f + 1) / 3;
        int h = (19 * a + b - d - g + 15) % 30;
        int i = c / 4;
        int k = c % 4;
        int l = (32 + 2 * e + 2 * i - h - k) % 7;
        int m = (a + 11 * h + 22 * l) / 451;
        int month = (h + l - 7 * m + 114) / 31;
        int day = ((h + l - 7 * m + 114) % 31) + 1;

        return new DateOnly(year, month, day);
    }
}
