using APISchedule.Data;
using APISchedule.Models;
using Microsoft.AspNetCore.Mvc;

namespace APISchedule.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ScheduleContext _context;
        public UserController(ScheduleContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("")]
        public ActionResult GetUser()
        {
            return Ok(_context.Users);
        }

        [HttpPost]
        [Route("")]
        public ActionResult CreateUser()
        {
            var user = new User();
            user.Nome = "Perereco";        
            user.Email = "perereco@hotmail.com";
            user.Senha = "perereco123";

            if (_context.Users != null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return Ok();
        }

    }
}
