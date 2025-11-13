using KTMS.Application.Modules.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Clubs.Commands.AddClub
{
    public class AddClubCommand : IRequest<int>
    {
        public AddClubDto AddClubDto { get; set; }
    }
}
