using Microsoft.AspNetCore.Mvc;
using DiningVsCodeNew;

namespace DiningVsCodeNew.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuCategoryController : ControllerBase
{
        MenuCategoryRepository repMenuCat;
        public MenuCategoryController(MenuCategoryRepository repMenuCat)
        {
            this.repMenuCat=repMenuCat;
        }
        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuCategory>>> GetMenuCategories()
        {
            return repMenuCat.GetMenuCategories();
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
        public async Task<IActionResult> PutMenuCategory(int id, MenuCategory menuCat)
        {
            if (id != menuCat.Id)
            {
                return BadRequest();
            }
           // _context.Entry(state).State = EntityState.Modified;
           
                repMenuCat.updateMenuCat(menuCat);
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
        public async Task<ActionResult<Menu>> PostMenuCat(MenuCategory menuCat)
        {
           
            if (menuCat!=null)
            {
                repMenuCat.insertMenuCat(menuCat);
            }
            return Ok("Posted succesfully");
            
        }
        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MenuCategory>> DeleteMenuCat(int id,MenuCategory menuCat)  
            {
              
              
                if (id != menuCat.Id)
                 {
                 return NotFound();
                }
                 id= repMenuCat.deleteMenuCat(menuCat);
                return Ok("Record Deleted succesfully");
            }
        //private bool StateExists(int id)
       // {
           // return _context.States.Any(e => e.Id == id);
       // }

}