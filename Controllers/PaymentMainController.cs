using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentMainController : ControllerBase
{
        PaymentMainRepository RepPymtMain;
        public PaymentMainController(PaymentMainRepository repPymtMain)
        {
            this.RepPymtMain=repPymtMain;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentMain>>> GetPymtMain()
        {
            return RepPymtMain.GetPymtMains();
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
        public async Task<IActionResult> PutPymtMain(int id, PaymentMain pymtMain)
        {
            if (id != pymtMain.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                RepPymtMain.updatePaymentMain(pymtMain);
                 return new OkObjectResult(pymtMain);
           
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
        public async Task<ActionResult<PaymentMain>> PostPymtMain(PaymentMain pymtMain)
        {
           
            if (pymtMain!=null)
            {
                pymtMain.DateServed=DateTime.Now;
                RepPymtMain.insertPaymentMain(pymtMain);
            }
            return Ok(pymtMain);
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentMain>> DeletePymtMain(int id,PaymentMain pymtMain)  
            {
              
              
                if (id != pymtMain.Id)
                 {
                 return NotFound();
                }

                 id= RepPymtMain.deletePymtMain(pymtMain);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}