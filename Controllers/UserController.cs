using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
        UserRepository repuser;
        public UserController(UserRepository repUser)
        {
            this.repuser=repUser;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return repuser.GetUsers();
        }
        // GET: api/Cities/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<User>> GetUser(int id)
       // {
           // var user = await repuser.getUsers(id);
           // if (user == null)
           // {
              //  return NotFound();
           // }
          //  return user;
       // }
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repuser.updateUser(user);
                return Ok("Record updated successfully");
           
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
           
            if (user!=null)
            {
                repuser.insertUser(user);
            }
            return Ok("Posted succesfully");
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id,User us)  
            {
              
              
                if (id != us.id)
                 {
                 return NotFound();
                }
                 id= repuser.deleteUser(us);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}