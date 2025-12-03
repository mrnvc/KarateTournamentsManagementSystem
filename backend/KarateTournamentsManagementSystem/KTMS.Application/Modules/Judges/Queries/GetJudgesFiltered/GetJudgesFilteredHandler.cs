using KTMS.Application.Abstractions;
using KTMS.Application.Common.Paging;
using KTMS.Application.Modules.Judges.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Judges.Queries.GetJudgesFiltered
{
    public class GetJudgesFilteredHandler : IRequestHandler<GetJudgesFilteredQuery, PageResult<JudgeFilterDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetJudgesFilteredHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PageResult<JudgeFilterDto>> Handle(GetJudgesFilteredQuery request, CancellationToken cancellationToken)
        {
            var query = _dbContext.Judges.AsQueryable();
            if (!string.IsNullOrEmpty(request.License))
            {
                query = query.Where(j => j.License.Contains(request.License));
            }

            if (!string.IsNullOrEmpty(request.Rank))
            {
                query = query.Where(j => j.Rank.Contains(request.Rank));
            }

            var dtoQuery = query.Select(j => new JudgeFilterDto
            {
                License = j.License,
                Rank = j.Rank
            });

            return await PageResult<JudgeFilterDto>.FromQueryableAsync(dtoQuery, request.Paging, cancellationToken);
        }
    }
}
