using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Models;
using UserManagementSystem.Services;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("getusers")]
        public async Task<ActionResult> GetUsers([FromQuery] UsersFilterParamsDto filterParams)
        {
            var userEntities = await _userRepository.GetUsersAsync(filterParams);
            return Ok(userEntities);
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var result = await _userRepository.AddUser(user);
            return Ok(result);
        }

        [HttpPatch("user")]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            var result = await _userRepository.UpdateUser(user);
            return Ok(result);
        }


        [HttpDelete("user/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            var result = await _userRepository.DeleteUser(id);
            return Ok(result);
        }

        [HttpPatch("user/assign")]
        public async Task<IActionResult> AssignUser([FromBody] User user)
        {
            var result = await _userRepository.AssignUser((Guid)user.Id, (bool)user.IsAdmin);
            return Ok(result);
        }
    }
}
