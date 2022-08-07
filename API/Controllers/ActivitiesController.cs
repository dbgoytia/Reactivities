using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
	public class ActivitiesController : BaseApiController
	{
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
		{
            this._context = context;
        }

        [HttpGet] //    /activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await this._context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //    /activites/id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await this._context.Activities.FindAsync(id);
        }

    }
}
