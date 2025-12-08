using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Categories.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Categories.Query.GetCategories
{
    public class GetCategoriesHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDto>>
    {
        private readonly IAppDbContext _dbContext;

        public GetCategoriesHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Categories
                                   .Include(c => c.Gender)
                                   .Include(c => c.Discipline)
                                   .Select(c => new CategoryDto
                                   {
                                        Discipline = c.Discipline.Name,
                                        Gender = c.Gender.Name,
                                        Name = c.Name,
                                        AgeGroup = c.AgeGroup,
                                        WeightClass = c.WeightClass
                                   })
                                   .ToListAsync(cancellationToken);
        }
    }
}
