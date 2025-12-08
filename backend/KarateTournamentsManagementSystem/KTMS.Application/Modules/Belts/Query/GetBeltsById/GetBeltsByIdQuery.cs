using KTMS.Application.Modules.Belts.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Belts.Query.GetBeltsById
{
    public class GetBeltsByIdQuery : IRequest<BeltDto>
    {
        public int Id { get; set; }
        public GetBeltsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
