using Holiday.App.Domain.Entities;
using Holiday.App.Infrastructure.Interfaces;
using MediatR;
using System.Collections.Generic;

namespace Holiday.App.Application.Commands;

public class QueryHolidayCommandHandler : IRequestHandler<QueryHolidayCommand, List<QueryHolidayResponse>>
{
    private readonly IService _service;

    public QueryHolidayCommandHandler(IService service)
    {
        _service = service;
    }

    public async Task<List<QueryHolidayResponse>> Handle(QueryHolidayCommand request, CancellationToken cancellationToken)
    {
        var response = _service.CalculateHolidayByYear(request.Year);
        List<QueryHolidayResponse> queryHolidayResponse = response
            .Select(holiday => new QueryHolidayResponse
            {
                Identifier = holiday.Identifier,
                Name = holiday.Name,
                DateOfHoliday = holiday.DateOfHoliday
            }).ToList();
        return queryHolidayResponse;
    }
}
