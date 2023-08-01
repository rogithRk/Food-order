using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbcontext _dbcontext;
        //private string email;

        public LoginController(ApplicationDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        //-----------------------------------------------------------------methods-----------------------------



        [HttpPost]  //-------------this methos for the sign process to  store the user data in the data base--->
        [Route("Create")]

        public IActionResult create([FromBody] Field log)
        {
            _dbcontext.Add(log);
            _dbcontext.SaveChanges();
            return Ok(log);
        }
        [HttpGet]    //-------------this method use for the get a user details perpose--->
        [Route ("GetAll")]

        public IActionResult getall() 
        {
            List<Field> Emails = new List<Field>();
            Emails =_dbcontext.login.ToList();
            return Ok(Emails);
       }
        [HttpGet]  //-------------this method is used to chick the email is valid or not --->
        [Route ("Email")]

        public IActionResult getAll(string email)
        {
            Field E1 = _dbcontext.login.FirstOrDefault(x =>x.Email==email);

            return Ok(E1);
        }




        

    }
}
