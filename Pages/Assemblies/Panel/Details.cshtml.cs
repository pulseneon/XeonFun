using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XeonFun.Data;
using XeonFun.Models;

namespace XeonFun.Pages.Assemblies.Panel
{
    public class DetailsModel : PageModel
    {
        private readonly XeonFun.Data.XeonFunContext _context;

        public DetailsModel(XeonFun.Data.XeonFunContext context)
        {
            _context = context;
        }

        public Assembling Assembling { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assembling = await _context.Assembling.FirstOrDefaultAsync(m => m.Id == id);

            if (Assembling == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
