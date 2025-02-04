using Persistence;
using Domain; // Add this line to include the namespace where Activity is defined
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController: BaseApiController
    {
        private readonly DataContext _context;
       
        public ActivitiesController(DataContext context)
        {
            _context = context;
  
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }
    }
}