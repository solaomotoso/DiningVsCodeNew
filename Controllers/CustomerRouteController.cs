using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;


namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerRouteController : ControllerBase
{
       
        CustomerRouteRepository _repCustRoute;
         
         int idvalue=0;
        public CustomerRouteController(CustomerRouteRepository repCustRoute)
        {
            this._repCustRoute=repCustRoute;
        }
        // GET: api/Cities
        [HttpPost("{getroutes}")]
        public async Task<ActionResult<IEnumerable<Route>>> Getroutes([FromBody] User us)
        {
            return _repCustRoute.GetCustomerRoutes(us);
        }
        // GET: api/Cities/5
       
}