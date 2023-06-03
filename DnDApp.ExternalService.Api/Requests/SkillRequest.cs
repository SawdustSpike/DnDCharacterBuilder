using DnDApp.ExternalService.DnDApi.Responses;

namespace DnDApp.ExternalService.DnDApi.Requests
{
    internal class GetAllSkillsRequest : GetAllRequest<DnDApiSkill> { }

    internal class GetSkillByNameRequest : GetByNameRequest<DnDApiSkill>
    {
        public GetSkillByNameRequest(string name) : base(name) { }
    }

    internal class GetSkillByIDRequest : GetByIdRequest<DnDApiSkill>
    {
        public GetSkillByIDRequest(int id) : base(id) { }
    }
}
