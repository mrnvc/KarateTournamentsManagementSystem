using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Coaches.Queries.GetCoaches
{
    public class GetCoachesQuery : IRequest<List<CoachDto>>
    {
    }
}
