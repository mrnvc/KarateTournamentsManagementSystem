using KTMS.Application.Abstractions;
using KTMS.Application.Modules.Categories.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KTMS.Application.Modules.Categories.Query.GetCategoriesById
{
    public class GetCategoriesByIdHandler : IRequestHandler<GetCategoriesByIdQuery, CategoryDto>
    {
        private readonly IAppDbContext _dbContext;

        public GetCategoriesByIdHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CategoryDto> Handle(GetCategoriesByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _dbContext.Categories
                                           .Include(c => c.Discipline)
                                           .Include(c => c.Gender)
                                           .FirstOrDefaultAsync(c => c.Id == request.Id);
            
            if (category == null)
            {
                throw new Exception("Category does not exist!"); 
            }

            return new CategoryDto
            {
                Discipline = category.Discipline.Name,
                Gender = category.Gender.Name,
                Name = category.Name,
                AgeGroup = category.AgeGroup,
                WeightClass = category.WeightClass
            };
        }
    }
}
