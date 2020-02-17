using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Travel_Manager.Models;

namespace Travel_Manager.Views.Home
{
    public class DisplayPageModel : PageModel
    {
        private readonly ApplicationPageClass _db;

        public DisplayPageModel(ApplicationPageClass db)
        {
            _db = db;
        }

        public IEnumerable<AddPage> getrecords { get; set; }
        public async Task OnGet()
        {
            getrecords = await _db.Posts.ToListAsync();
        }
    }
}
