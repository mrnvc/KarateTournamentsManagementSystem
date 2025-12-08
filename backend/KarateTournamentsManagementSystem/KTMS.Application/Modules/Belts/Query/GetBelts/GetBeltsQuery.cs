using KTMS.Application.Modules.Belts.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Belts.Query.GetBelts
{
    public class GetBeltsQuery : IRequest<List<BeltDto>>
    {
    }
}
