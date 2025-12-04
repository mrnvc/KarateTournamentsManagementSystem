using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Countries.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Countries.Query.GetCountries
{
    public class GetCountriesHandler : IRequestHandler<GetCountriesQuery, List<CountryDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetCountriesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CountryDto>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
        {
            var countries = await _dbContext.Countries
                                            .Select(c => new CountryDto
                                            {
                                                Name = c.Name
                                            })
                                            .ToListAsync(cancellationToken);

            return countries;
        }
    }
}
