using KTMS.Application.Modules.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Clubs.Commands.UpdateClub
{
    public class UpdateClubCommand : IRequest<int>
    {
        public int Id { get; set; }
        public UpdateClubDto UpdateClubDto { get; set; }
    }
}
