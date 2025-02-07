using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NathansForum.Models;
using NathansForum.Data;
using Microsoft.EntityFrameworkCore;

namespace NathansForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly NathansForumContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(NathansForumContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("")]
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var discussion = await _context.Discussion.Include(m => m.Comments).ToListAsync();
            return View(discussion);
        }

        [HttpGet("Home/GetDiscussion/{id:int}")]
        public async Task<IActionResult> GetDiscussion(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Discussion ID was null.");
                return NotFound();
            }

            var discussion = await _context.Discussion
                                           .Include(m => m.Comments)
                                           .FirstOrDefaultAsync(m => m.DiscussionId == id);

            if (discussion == null)
            {
                _logger.LogWarning($"Discussion with ID {id} not found.");
                return NotFound();
            }

            return View(discussion);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
