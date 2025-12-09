using KTMS.Application.Modules.Discipline.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Discipline.Queries.GetDisciplines
{
    public class GetDisciplinesQuery : IRequest<List<DisciplineDto>>
    {
    }
}
