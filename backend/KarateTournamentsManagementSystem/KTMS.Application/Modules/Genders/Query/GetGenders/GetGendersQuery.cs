using KTMS.Application.Modules.Genders.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Genders.Query.GetGenders
{
    public class GetGendersQuery : IRequest<List<GenderDto>>
    {
    }
}
