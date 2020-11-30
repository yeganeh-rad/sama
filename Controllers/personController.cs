using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sama.Models;
namespace  sama.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class personController : ControllerBase{
        [HttpGet("{id}")]
           public string getPerson(int id)
            {
                return "retuend string"+id;
            }
    }
    
}