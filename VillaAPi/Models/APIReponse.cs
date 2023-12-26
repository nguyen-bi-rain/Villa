using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Net;

namespace VillaAPi.Models
{
    public class APIReponse
    {
        public APIReponse()
        {
            ErrorsMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorsMessages { get; set; }

        public object Result { get; set; }
    }
}
