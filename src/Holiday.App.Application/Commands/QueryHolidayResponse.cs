
namespace Holiday.App.Application.Commands;

public class QueryHolidayResponse
{
    public Guid Identifier { get; set; }
    public DateOnly DateOfHoliday { get; set; }
    public required string Name { get; set; }

    public static explicit operator QueryHolidayResponse(List<Domain.Entities.Holiday> v)
    {
        throw new NotImplementedException();
    }
}
