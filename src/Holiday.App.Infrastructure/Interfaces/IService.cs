namespace Holiday.App.Infrastructure.Interfaces;

public interface IService
{
    List<Domain.Entities.Holiday> CalculateHolidayByYear(int year);
}
