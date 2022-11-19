using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPIWorkSearch.Service;
using WebAPIWorkSearch.View;

namespace WebAPIWorkSearch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost] 
        public ActionResult<UserView> Post([FromBody] UserView userView)
        {
            _userService.InsertUser(userView);
            return userView;
        }

        [HttpPut, Route("{id}")]
        public ActionResult<UserView> Put([FromRoute] int id, [FromBody] UserView userView)
        {
            _userService.UpdateUser(id, userView);
            return userView;
        }

        [HttpPut, Route("delete/{id}")]
        public ActionResult<UserView> Delete([FromRoute] int id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public ActionResult<UserView> Get([FromRoute] int id)
        {
            return _userService.GetUser(id);
        }

        [HttpGet]
        public ActionResult<List<UserView>> GetAll()
        {
            return _userService.GetAll();
        }
    }
}
