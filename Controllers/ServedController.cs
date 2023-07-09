using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class ServedController : ControllerBase
{
       
        ServedRepository repserv;
         private EmailConfiguration _emailConfig;
         int idvalue=0;
        public ServedController(ServedRepository repserv,EmailConfiguration emailConfig)
        {
            this.repserv=repserv;
            this._emailConfig=emailConfig;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetServed()
        {
            return new OkObjectResult(repserv.GetServeds());
        }
        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetServed(int id)
        {
            return new OkObjectResult(repserv.GetServed(id));
          
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServed(int id,  Served serv )
        { 
            if (id != serv.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repserv.updateServed(serv);
                return new OkObjectResult(serv);
           
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
        public async Task<ActionResult<User>> PostServ(Served serv)
        {
            if (serv!=null)
            {
                repserv.insertServed(serv);
            }
            return Ok(serv);
            
        }
        // DELETE: api/Cities/5
        [HttpPost("deleteserved")]
        public async  Task <IActionResult> Delete([FromBody] Served serv)  
            {
              
                // if (idvalue != us.id)
                //  {
                //  return NotFound();
                //  }
                idvalue = repserv.deleteServed(serv);
                return Ok(serv);
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}