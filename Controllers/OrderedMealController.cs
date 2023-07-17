using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderedMealController : ControllerBase
{
        OrderedMealRepository ordMeal;
        public OrderedMealController(OrderedMealRepository ordMeal)
        {
            this.ordMeal=ordMeal;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetOrdMeals()
        {
            return new OkObjectResult(ordMeal.GetOrderedMeals());
        }
        // GET: api/Cities/5
         [HttpPost("getordmealsbycust")]
        public async Task<ActionResult<IEnumerable<OrderedMeal>>> GetPaidPaymentsbyCust([FromBody] User us)
        {
            return ordMeal.GetOrderedMealsbyCust(us);
        }
       
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdMeal(int id, OrderedMeal ordMeal)
        {
            if (id != ordMeal.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                this.ordMeal.updateOrderedMeal(ordMeal);
                return new OkObjectResult(ordMeal);
           
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
        public async Task<ActionResult<OrderedMeal>> PostOrderedMeal(OrderedMeal omeal)
        {
           
            if (omeal!=null)
            {
                Menu selectedmenu=new Menu();
                omeal.Active=true;
                ordMeal.insertOrderedMeal(omeal);
            }
            return new OkObjectResult(omeal);
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrderedMeal>> DeleteOrderedMeal(int id,OrderedMeal oMeal)  
            {
              
              
                if (id != oMeal.Id)
                 {
                 return NotFound();
                }
                 id= ordMeal.deleteOrderedMeal(oMeal);
                return new OkObjectResult(oMeal);
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}