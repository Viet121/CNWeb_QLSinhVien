using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace backend.Controllers{

    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public HomeController (DatabaseContext context){
            this._context = context;
        }
        [HttpGet("[action]")]
        public async Task<IEnumerable<Khoa>> Get()
        {
            return await _context.khoas.ToListAsync();
        }
    }
}
