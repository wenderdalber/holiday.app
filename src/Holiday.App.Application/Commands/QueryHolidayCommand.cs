using MediatR;

namespace Holiday.App.Application.Commands;

public class QueryHolidayCommand : IRequest<List<QueryHolidayResponse>>
{
    public int Year { get; set; }
}
