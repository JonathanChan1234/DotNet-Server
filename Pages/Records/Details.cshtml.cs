using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Records
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RecordContext _context;

        public DetailsModel(RazorPagesMovie.Data.RecordContext context)
        {
            _context = context;
        }

        public Record Record { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Record = await _context.Record.FirstOrDefaultAsync(m => m.recordID == id);

            if (Record == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
