using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Coaches.Queries.GetCoachesById
{
    public class GetCoachesByIdQuery : IRequest<CoachDto>
    {
        public int Id { get; set; }
        public GetCoachesByIdQuery(int id)
        {
            Id = id;
        }
    }
}
