using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sama.Data;
using sama.Models;
namespace  sama.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class personController : ControllerBase{
        //pass the context that created by DI in startup class
        private readonly MvcUserContext _context;
        public personController(MvcUserContext context)
        {
            _context=context;
        }

        [HttpGet("{id}")]
           public async Task<ActionResult<user>> getPerson(int id)
            {
                user person=await _context.User.FindAsync(id);
                
                //user person=new user(){ID=129,name="arash yeganeh rad"};
                return person;
            }
    }
    
}