using KTMS.Application.Modules.Discipline.Dtos;
using MediatR;

namespace KTMS.Application.Modules.Discipline.Query.GetDisciplines
{
    public class GetDisciplinesQuery : IRequest<List<DisciplineDto>>
    {
    }
}
