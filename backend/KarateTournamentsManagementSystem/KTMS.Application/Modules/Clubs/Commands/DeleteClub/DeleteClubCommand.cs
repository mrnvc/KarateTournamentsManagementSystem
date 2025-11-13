using MediatR;

namespace KTMS.Application.Modules.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
