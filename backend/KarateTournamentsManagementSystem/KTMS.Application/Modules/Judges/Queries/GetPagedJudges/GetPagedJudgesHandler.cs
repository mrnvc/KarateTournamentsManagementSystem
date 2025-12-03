using KTMS.Application.Abstractions;
using KTMS.Application.Common.Paging;
using KTMS.Application.Modules.Judges.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Judges.Queries.GetPagedJudges
{
    public class GetPagedJudgesHandler : IRequestHandler<GetPagedJudgesQuery, PageResult<JudgeDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetPagedJudgesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PageResult<JudgeDto>> Handle(GetPagedJudgesQuery request, CancellationToken cancellationToken)
        {
            var query = _dbContext.Judges
                                  .Select(j => new JudgeDto
                                  {
                                      Id = j.Id,
                                      UserId = j.UserId,
                                      Name = j.User.Name,
                                      Surname = j.User.Surname,
                                      PhoneNumber = j.User.PhoneNumber,
                                      Email = j.User.Email,
                                      License = j.License,
                                      Rank = j.Rank
                                  });

            return await PageResult<JudgeDto>.FromQueryableAsync(query, request.Paging, cancellationToken);
        }
    }
}
