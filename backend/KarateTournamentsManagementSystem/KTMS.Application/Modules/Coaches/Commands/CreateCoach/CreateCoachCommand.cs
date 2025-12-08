using KTMS.Application.Modules.Clubs.Dtos;
using KTMS.Application.Modules.Coaches.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Coaches.Commands.CreateCoach
{
    public class CreateCoachCommand : IRequest<int>
    {
        public CreateCoachDto CreateCoachDto { get; set; }
    }
}
