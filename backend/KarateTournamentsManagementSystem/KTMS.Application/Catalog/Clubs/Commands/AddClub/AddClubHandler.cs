using KTMS.Application.Abstractions;
using KTMS.Domain.Entities;
using MediatR;

namespace KTMS.Application.Catalog.Clubs.Commands.AddClub
{
    public class AddClubHandler : IRequestHandler<AddClubCommand, int>
    {
        private readonly IAppDbContext _dbContext;

        public AddClubHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle (AddClubCommand request, CancellationToken cancellationToken)
        {
            var dto = request.AddClubDto;

            var club = new Club
            {
                CityId = dto.CityId,
                CountryId = dto.CountryId,
                Name = dto.Name,
                Address = dto.Address,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Status = true
            };

            _dbContext.Clubs.Add(club);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return club.Id;
        }
    }
}
