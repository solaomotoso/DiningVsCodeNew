using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew.Models;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class OnlinePaymentController : ControllerBase
{
       private OnlinePaymentRepository reponlinePayment;
         int idvalue=0;
        public OnlinePaymentController(OnlinePaymentRepository reponlinePymt)
        {
            this.reponlinePayment=reponlinePymt;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetOnlinePayments()
        {
            return new OkObjectResult(reponlinePayment.GetOnlinePayments());
        }
        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OnlinePayment>> GetOnlinePayment(int id)
        {
            return new OkObjectResult(reponlinePayment.GetOnlinePayment(id));
          
        }

        //  [HttpGet("getuser/{userName}")]
        //  public async Task<ActionResult<User>> GetUser(string username)
        // {
        //     return new OkObjectResult(repuser.GetUser(username));  
        // }
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOnlinePayment(int id,  OnlinePayment onlinePymt )
        { 
            if (id != onlinePymt.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
               this.reponlinePayment.updateOnlinePayment(onlinePymt);
                return new OkObjectResult(onlinePymt);
           
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
        public async Task<ActionResult<OnlinePayment>> PostOnlinePayment(OnlinePayment onlinePymt)
        {
           
            if (onlinePymt!=null)
            {
                reponlinePayment.insertOnlinePayment(onlinePymt);
            }
            return Ok(onlinePymt);
            
        }
        // DELETE: api/Cities/5
        [HttpPost("deleteonlinePayment")]
        public async  Task <IActionResult> Delete([FromBody] OnlinePayment onlinePymt)  
            {
              
                // if (idvalue != us.id)
                //  {
                //  return NotFound();
                //  }
                idvalue = reponlinePayment.deleteOnlinePayment(onlinePymt);
                return Ok(onlinePymt);
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}