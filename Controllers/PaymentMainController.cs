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
        // [HttpGet("{id}")]
    //     public async Task<ActionResult<PaymentMain>> GetPymtMain(int id)
    //    {
    //     //    var user = await repuser.getUsers(id);
    //        if (id != null)
    //        {
    //            return new OkObjectResult(repuser.GetUsers());
    //        }
         
    //    }
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("updatepayment")]
        public async Task<IActionResult> PutPymtMain([FromBody] PaymentMain pymtMain)
        {

                RepPymtMain.updatePaymentMain(pymtMain);
                return new OkObjectResult(pymtMain);
           
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
                pymtMain.timepaid=DateTime.Now;
                RepPymtMain.insertPaymentMain(pymtMain);
            }
            return Ok(pymtMain);
            
        }
        // DELETE: api/Cities/5
        [HttpPost("deletepymtmain")]
        public async Task<IActionResult> delete([FromBody] PaymentMain pymtMain)  
            {
                pymtMain.DateServed=DateTime.Now;
                pymtMain.timepaid=DateTime.Now;
               int idvalue=0;
               idvalue = RepPymtMain.deletePymtMain(pymtMain);
                return Ok(pymtMain);
                
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}