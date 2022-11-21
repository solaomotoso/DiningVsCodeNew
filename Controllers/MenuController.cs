using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{
        MenuRepository repMenu;
        public MenuController(MenuRepository repMenu)
        {
            this.repMenu=repMenu;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult> GetMenus()
        {
            return new OkObjectResult(repMenu.GetMenus());
        }
        // GET: api/Cities/5
       [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetMenu(int id)
        {
            return new OkObjectResult(repMenu.GetMenu(id));
          
        }
        // PUT: api/users/5
        // To protect from overposting attacks, see https://go.microsoft.com/
        // fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repMenu.updateMenu(menu);
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
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
           
            if (menu!=null)
            {
                repMenu.insertMenu(menu);
            }
            return Ok("Posted succesfully");
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Menu>> DeleteMenu(int id,Menu menu)  
            {
              
              
                if (id != menu.Id)
                 {
                 return NotFound();
                }
                 id= repMenu.deleteMenu(menu);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}