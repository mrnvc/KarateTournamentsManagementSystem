using KTMS.Application.Modules.Categories.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Categories.Query.GetCategories
{
    public class GetCategoriesQuery : IRequest<List<CategoryDto>>
    {
    }
}
