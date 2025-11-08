using MediatR;

namespace KTMS.Application.Catalog.Clubs.Commands.DeleteClub
{
    public class DeleteClubCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
