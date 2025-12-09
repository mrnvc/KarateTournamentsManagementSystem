using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Countries.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Countries.Queries.GetCountriesById
{
    public class GetCountriesByIdHandler : IRequestHandler<GetCountriesByIdQuery, CountryDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetCountriesByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CountryDto> Handle(GetCountriesByIdQuery request, CancellationToken cancellationToken)
        {
            var country = await _dbContext.Countries.FirstOrDefaultAsync(c => c.Id == request.Id);
            
            if (country == null)
            {
                throw new Exception("Country does not exist");
            }

            return new CountryDto
            {
                Name = country.Name
            };
        }
    }
}
