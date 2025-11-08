using KTMS.Application.Catalog.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Catalog.Clubs.Commands.AddClub
{
    public class AddClubCommand : IRequest<int>
    {
        public AddClubDto AddClubDto { get; set; }
    }
}
