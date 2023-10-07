using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class ServedController : ControllerBase
{

    ServedRepository repserv;
    private EmailConfiguration _emailConfig;
    int idvalue = 0;
    public ServedController(ServedRepository repserv, EmailConfiguration emailConfig)
    {
        this.repserv = repserv;
        this._emailConfig = emailConfig;
    }
    // GET: api/Cities
    [HttpGet]
    public async Task<ActionResult> GetServed()
    {
        return new OkObjectResult(repserv.GetServeds());
    }
    [HttpPost("getServedbyCustomer")]
    public async Task<ActionResult> GetServed([FromBody] User us)
    {
        return new OkObjectResult(repserv.GetServedbyCustomer(us.id));
    }
    // GET: api/Cities/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetServed(int id)
    {
        return new OkObjectResult(repserv.GetServed(id));

    }


    [HttpPost("{id}")]
    public async Task<IActionResult> PutServed(int id, Served serv)
    {
        if (id != serv.Id)
        {
            return BadRequest();
        }
        // _context.Entry(state).State = EntityState.Modified;

        repserv.updateServed(serv);
        return new OkObjectResult(serv);

    }
    [HttpPost("updateServed")]
    public async Task<IActionResult> PutPymtMain([FromBody] Served serv)
    {

        repserv.updateServed(serv);
        return new OkObjectResult(serv);

    }
    //return NoContent();
    // POST: api/Cities
    // To protect from overposting attacks, see https://go.microsoft.com/
    //fwlink /? linkid = 2123754
    [HttpPost]
    public async Task<ActionResult<User>> PostServ(Served serv)
    {
        if (serv != null)
        {
            repserv.insertServed(serv);
        }
        return Ok(serv);

    }
    // DELETE: api/Cities/5
    [HttpPost("deleteserved")]
    public async Task<IActionResult> Delete([FromBody] Served serv)
    {

        Served sv = new Served();
        sv.Id = serv.Id;
        sv.Dateserved = serv.Dateserved;
        sv.isServed = serv.isServed;
        // sv.paymentMain=serv.paymentMain;        
        idvalue = repserv.deleteServed(sv);
        return Ok(serv);
    }
    //private bool StateExists(int id)
    // {
    // return _context.States.Any(e => e.Id == id);
    // }

}