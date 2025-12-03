using KTMS.Application.Common.Paging;
using KTMS.Application.Modules.Judges.Dtos;

namespace KTMS.Application.Modules.Judges.Queries.GetJudgesFiltered
{
    public class GetJudgesFilteredQuery : BasePagedQuery<JudgeFilterDto>
    {
        public string? License { get; set; }
        public string? Rank { get; set; }

        //moze li se dodati filter po imenu ili prezimenu ako bude potrebno
        //i zasto se koristi basePagedQuery
    }
}
