using KTMS.Application.Modules.Categories.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Categories.Queries.GetCategories
{
    public class GetCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }
}
