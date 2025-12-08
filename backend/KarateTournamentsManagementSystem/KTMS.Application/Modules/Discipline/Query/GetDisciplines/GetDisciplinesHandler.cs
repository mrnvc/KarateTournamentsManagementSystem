using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Discipline.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Discipline.Query.GetDisciplines
{
    public class GetDisciplinesHandler : IRequestHandler<GetDisciplinesQuery, List<DisciplineDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetDisciplinesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<DisciplineDto>> Handle(GetDisciplinesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Disciplines
                                    .Select(d => new DisciplineDto {
                                        Name = d.Name,
                                        Description = d.Description
                                    })
                                    .ToListAsync(cancellationToken);
        }
    }
}
