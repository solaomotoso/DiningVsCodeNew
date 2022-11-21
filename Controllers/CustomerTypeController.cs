using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerTypeController : ControllerBase
{
        CustomerTypeRepository repCustType;
        public CustomerTypeController(CustomerTypeRepository repCType)
        {
            this.repCustType=repCType;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetCtypes()
        {
             return new OkObjectResult(repCustType.GetCustomerTypes());
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
        public async Task<IActionResult> PutCType(int id, CustomerType Custtype)
        {
            if (id != Custtype.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repCustType.updateCustomerType(Custtype);
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
        public async Task<ActionResult<CustomerType>> PostCType(CustomerType ctype)
        {
           
            if (ctype!=null)
            {
                repCustType.insertCustomerType(ctype);
            }
            return Ok("Posted succesfully");
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerType>> DeleteMenu(int id,CustomerType custtype)  
            {
              
              
                if (id != custtype.Id)
                 {
                 return NotFound();
                }
                 id= repCustType.deleteCustomerType(custtype);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}