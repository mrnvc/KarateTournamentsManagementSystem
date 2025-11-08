using KTMS.Application.Catalog.Clubs.Dtos;
using MediatR;

namespace KTMS.Application.Catalog.Clubs.GetClubs.GetClubsById
{
    public class GetClubsByIdQuery : IRequest<ClubDto>
    {
        public int Id { get; set; }
        public GetClubsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
