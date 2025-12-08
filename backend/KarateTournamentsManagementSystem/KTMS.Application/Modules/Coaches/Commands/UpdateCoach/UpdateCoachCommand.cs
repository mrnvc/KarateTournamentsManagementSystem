using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Coaches.Commands.UpdateCoach
{
    public class UpdateCoachCommand : IRequest<int>
    {
        public int Id { get; set; }
        public UpdateCoachDto UpdateCoachDto { get; set; }
    }
}
