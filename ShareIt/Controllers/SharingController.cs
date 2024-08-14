using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShareIt.DTO;
using ShareIt.Models;
using ProductsAPI.DTO;

namespace ShareIt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SharingController : ControllerBase
    {
        private readonly ShareContext _context;

        public SharingController(ShareContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSharing()
        {
            var sharing = await _context.Sharings
                .Select(p => ShareToDTO(p)) // DTO'ya map'leme
                .ToListAsync();

            return Ok(sharing);
        }

        [HttpPost]
public async Task<IActionResult> PostSharing(Sharing entity)
{
    _context.Sharings.Add(entity);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetSharing), new { id = entity.SharingID }, entity);
}




        // Sharing entity'sini ShareDTO'ya çeviren metot
        private static ShareDTO ShareToDTO(Sharing p)
        {
            return new ShareDTO
            {
                SharingID = p.SharingID,
                Text = p.Text,
                User = new UserDTO
                {
                    UserId= p.User.UserId,
                    UserName = p.User.UserName
                }
            };
        }
    }
}
