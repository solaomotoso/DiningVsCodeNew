using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentDetailsController : ControllerBase
{
        PaymentDetailsRepository repPayDetails;
        public PaymentDetailsController(PaymentDetailsRepository repPayDetails)
        {
            this.repPayDetails=repPayDetails;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetails>>> GetPaymentDetails()
        {
            return new OkObjectResult(repPayDetails.GetPymtDetails());
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
        public async Task<IActionResult> PutPymtDetails(int id, PaymentDetails pymtDetails)
        {
            if (id != pymtDetails.id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repPayDetails.updatePaymentDetails(pymtDetails);
                 return new OkObjectResult(pymtDetails);
           
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
        public async Task<ActionResult<PaymentDetails>> PostPymtDetails(PaymentDetails pymtDetails)
        {
           
            if (pymtDetails!=null)
            {
                repPayDetails.insertPaymentDetails(pymtDetails);
            }
            return Ok("Posted succesfully");
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentDetails>> DeletePymtDetails(int id,PaymentDetails pymtDetails)  
            {
              
              
                if (id != pymtDetails.id)
                 {
                 return NotFound();
                }
                 id= repPayDetails.deletePymtDetails(pymtDetails);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}