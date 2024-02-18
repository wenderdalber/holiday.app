namespace Holiday.App.Domain.Entities;

public class Holiday
{
    public Guid Identifier { get;set; }
    public DateOnly DateOfHoliday { get; set; }
    public required string Name { get; set; }

    public static Holiday Create(Guid identifier, DateOnly dateOfHoliday, HolidaysName holidayName)
    {
        return new Holiday
        {
            Identifier = identifier,
            DateOfHoliday = dateOfHoliday,
            Name = holidayName.ToString()
        };
    }
}

public enum HolidaysName
{
    Easter = 1,
    CorpusChristi = 2,
    Dead = 3,
    Christmas = 4
}
