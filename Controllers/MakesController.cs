using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly IMapper _mapper;

        private readonly VegaDbContext _context;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await _context.Makes.Include(m => m.Models).ToListAsync();
            return this._mapper.Map<List<Make>, List<MakeResource>>(makes);

        }
    }
}