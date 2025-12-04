using MediatR;

namespace KTMS.Application.Modules.Coaches.Commands.DeleteCoach
{
    public class DeleteCoachCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
