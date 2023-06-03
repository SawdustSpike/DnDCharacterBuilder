using DnDApp.ExternalService.DnDApi.Responses;

namespace DnDApp.ExternalService.DnDApi.Requests
{
    internal class GetAllAlignmentsRequest : GetAllRequest<DnDApiAlignment> { }

    internal class GetAlignmentByNameRequest : GetByNameRequest<DnDApiAlignment>
    {
        public GetAlignmentByNameRequest(string name) : base(name) { }
    }

    internal class GetAlignmentByIDRequest : GetByIdRequest<DnDApiAlignment>
    {
        public GetAlignmentByIDRequest(int id) : base(id) { }
    }
}