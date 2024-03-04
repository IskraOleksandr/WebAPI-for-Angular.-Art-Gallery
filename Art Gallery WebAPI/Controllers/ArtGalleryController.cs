using Art_Gallery_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Art_Gallery_WebAPI.Controllers
{
    [ApiController]
    [Route("api/ArtWorks")]
    public class ArtGalleryController : ControllerBase
    {
        private readonly ArtGalleryContext _context;

        public ArtGalleryController(ArtGalleryContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtWork>>> GetArtWorks()
        {
            return await _context.ArtWorks.ToListAsync();
        }
        // GET: api/Students/3
        [HttpGet("{id}")]
        public async Task<ActionResult<ArtWork>> GetArtWork(int id)
        {
            var artWork = await _context.ArtWorks.SingleOrDefaultAsync(m => m.Id == id);
            if (artWork == null)
            {
                return NotFound();
            }
            return new ObjectResult(artWork);
        }

    }
}
