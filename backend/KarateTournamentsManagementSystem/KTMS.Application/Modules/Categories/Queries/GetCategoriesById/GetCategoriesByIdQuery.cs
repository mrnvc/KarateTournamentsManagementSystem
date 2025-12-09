using KTMS.Application.Modules.Categories.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Categories.Queries.GetCategoriesById
{
    public class GetCategoriesByIdQuery : IRequest<CategoryDto>
    {
        public int Id { get; set; }

        public GetCategoriesByIdQuery(int id)
        {
            Id = id; 
        }
    }
}
