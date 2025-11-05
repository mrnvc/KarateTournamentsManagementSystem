using KTMS.Infrastructure.Database;
using Microsoft.AspNetCore.Mvc;

namespace Karate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestConnectionController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public TestConnectionController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("check")]
        public IActionResult CheckConnection()
        {
            try
            {
                // Ovo će pokušati da se poveže sa bazom
                var canConnect = _context.Database.CanConnect();

                if (canConnect)
                    return Ok("✅ Database connection successful!");
                else
                    return StatusCode(500, "❌ Cannot connect to the database.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"❌ Connection failed: {ex.Message}");
            }
        }
    }
}
