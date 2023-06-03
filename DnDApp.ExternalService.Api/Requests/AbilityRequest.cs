using DnDApp.ExternalService.DnDApi.Responses;

namespace DnDApp.ExternalService.DnDApi.Requests
{
    internal class GetAllAbilitiesRequest : GetAllRequest<DnDApiAbility> { }

    internal class GetAbilityByNameRequest : GetByNameRequest<DnDApiAbility>
    {
        public GetAbilityByNameRequest(string name) : base(name) { }
    }

    internal class GetAbilityByIDRequest : GetByIdRequest<DnDApiAbility>
    {
        public GetAbilityByIDRequest(int id) : base(id) { }
    }
}
