using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Belts.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Belts.Query.GetBeltsById
{
    public class GetBeltsByIdHandler : IRequestHandler<GetBeltsByIdQuery, BeltDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetBeltsByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<BeltDto> Handle(GetBeltsByIdQuery request, CancellationToken cancellationToken)
        {
            var belt = await _dbContext.Belts
                                       .FirstOrDefaultAsync(b => b.Id == request.Id);

            if (belt == null)
            {
                throw new Exception($"Belt with ID {request.Id} not found.");
            }

            return new BeltDto
            {  
                Name = belt.Name,
                RankOrder = belt.RankOrder,
                Description = belt.Description
            };
        }
    }
}
