using Villa_Web.Models;

namespace Villa_Web.Services.IServices
{
    public interface IBaseService
    {
        APIReponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
