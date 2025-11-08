using KTMS.Application.Catalog.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Catalog.Clubs.Commands.UpdateClub
{
    public class UpdateClubCommand : IRequest<int>
    {
        public int Id { get; set; }
        public UpdateClubDto UpdateClubDto { get; set; }
    }
}
