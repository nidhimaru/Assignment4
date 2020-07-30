using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment4.Data;
using Assignment4.NewFolder2;

namespace Assignment4.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Assignment4.Data.AppDbContext _context;

        public IndexModel(Assignment4.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
