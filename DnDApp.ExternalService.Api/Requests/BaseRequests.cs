namespace DnDApp.ExternalService.DnDApi.Requests
{
    public abstract class DnDApiRequest<TResponse> { }
    
    internal abstract class GetAllRequest<TResponse> : DnDApiRequest<IEnumerable<TResponse>> { }

    internal abstract class GetByIdRequest<TResponse> : DnDApiRequest<TResponse>
    {
        public GetByIdRequest(int id) => id = id;

        public int Id { get; }
    }

    internal abstract class GetByNameRequest<TResponse> : DnDApiRequest<IEnumerable<TResponse>>
    {
        public GetByNameRequest(string name) => Name = name;

        public string Name { get; }
    }
}
