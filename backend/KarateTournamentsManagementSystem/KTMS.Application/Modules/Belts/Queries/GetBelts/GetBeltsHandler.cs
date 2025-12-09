using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Belts.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Belts.Queries.GetBelts
{
    public class GetBeltsHandler : IRequestHandler<GetBeltsQuery, List<BeltDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetBeltsHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BeltDto>> Handle(GetBeltsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Belts
                                   .Select(b => new BeltDto
                                   {
                                       Name = b.Name,
                                       Description = b.Description,
                                       RankOrder = b.RankOrder
                                   })
                                   .ToListAsync(cancellationToken);
        }
    }
}
