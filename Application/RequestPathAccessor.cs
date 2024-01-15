
using Microsoft.AspNetCore.Http;

public class RequestPathAccessor : IRequestPathAccessor
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public RequestPathAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    public string GetRequestPath()
    {
        return _httpContextAccessor.HttpContext.Request.Path;
    }
}