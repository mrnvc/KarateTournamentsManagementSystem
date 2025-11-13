using KTMS.Application.Modules.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Clubs.GetClubs.GetClubs
{
    public class GetClubsQuery : IRequest<List<ClubDto>>
    {
    }
}
