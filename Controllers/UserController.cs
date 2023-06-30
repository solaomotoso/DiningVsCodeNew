using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
       
        UserRepository repuser;
         private EmailConfiguration _emailConfig;
         int idvalue=0;
        public UserController(UserRepository repUser,EmailConfiguration emailConfig)
        {
            this.repuser=repUser;
            this._emailConfig=emailConfig;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return new OkObjectResult(repuser.GetUsers());
        }
        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return new OkObjectResult(repuser.GetUser(id));
          
        }

         [HttpGet("getuser/{userName}")]
         public async Task<ActionResult<User>> GetUser(string username)
        {
            return new OkObjectResult(repuser.GetUser(username));  
        }
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id,  User user )
        { 
            if (id != user.id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repuser.updateUser(user);
                return new OkObjectResult(user);
           
           // catch (DbUpdateConcurrencyException)
           // {
               // if (!StateExists(id))
              //  {
                  //  return NotFound();
               // }
               // else
              //  {
                   // throw;
               // }
        }
            //return NoContent();
        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/
        //fwlink /? linkid = 2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            
        //     EmailSender _emailSender=new EmailSender(this._emailConfig);
        //    var message = new Message(new string[] { "olusola.omotoso@evercare.ng" }, "Test email", "This is the content from our email.");
        //    _emailSender.SendEmail(message);
        //    await _emailSender.SendEmailAsync(message);
            if (user!=null)
            {
                repuser.insertUser(user);
            }
            return Ok(user);
            
        }
        // DELETE: api/Cities/5
        [HttpPost("deleteuser")]
        public async  Task <IActionResult> Delete([FromBody] User us)  
            {
              
                // if (idvalue != us.id)
                //  {
                //  return NotFound();
                //  }
                idvalue = repuser.deleteUser(us);
                return Ok(us);
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}