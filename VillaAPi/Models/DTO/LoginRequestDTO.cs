using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace VillaAPi.Models.DTO
{
    public class LoginRequestDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
