using Microsoft.AspNetCore.Mvc;
using System.Net;
using VillaAPi.Models;
using VillaAPi.Models.DTO;
using VillaAPi.Repository.IRepository;

namespace VillaAPi.Controllers
{
    [Route("api/UsersAuth")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private APIReponse _reponse;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            this._reponse = new();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
        {
            var LoginResponse = await _userRepository.Login(model);
            if(LoginResponse.User == null || string.IsNullOrEmpty(LoginResponse.Token))
            {
                _reponse.StatusCode = HttpStatusCode.BadRequest;
                _reponse.IsSuccess = false;
                _reponse.ErrorsMessages.Add("UserName or Password is incorrect");
                return BadRequest(_reponse);
            }
            _reponse.StatusCode = HttpStatusCode.OK;
            _reponse.IsSuccess = true;
            _reponse.Result = LoginResponse;
            return Ok(_reponse);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterationRequestDTO model)
        {
            bool ifUserNameUnique = _userRepository.isUniqueUser(model.UserName);
            if(!ifUserNameUnique)
            {
                _reponse.StatusCode = HttpStatusCode.BadRequest;
                _reponse.IsSuccess = false;
                _reponse.ErrorsMessages.Add("UserName Already Exists");
                return BadRequest(_reponse);
            }
            var user = await _userRepository.Register(model);
            if(user == null)
            {
                _reponse.StatusCode = HttpStatusCode.BadRequest;
                _reponse.IsSuccess = false;
                _reponse.ErrorsMessages.Add("Error while registering");
                return BadRequest(_reponse);
            }
            _reponse.StatusCode = HttpStatusCode.OK;
            _reponse.IsSuccess = true;
            return Ok(_reponse);
        }
    }
}
