using KTMS.Application.Catalog.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Catalog.Clubs.GetClubs.GetClubs
{
    public class GetClubsQuery : IRequest<List<ClubDto>>
    {
    }
}
