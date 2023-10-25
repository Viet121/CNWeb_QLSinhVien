using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    private readonly DatabaseContext context;

    public HomeController(DatabaseContext context){
        this.context=context;
   }

    [HttpGet("action")]
    public async Task<IEnumerable<Sinhvien>> Get(){
        return await context.Sinhviens.ToListAsync();
    }
}
