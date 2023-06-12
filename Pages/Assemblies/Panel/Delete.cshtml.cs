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
    public class DeleteModel : PageModel
    {
        private readonly XeonFun.Data.XeonFunContext _context;

        public DeleteModel(XeonFun.Data.XeonFunContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assembling = await _context.Assembling.FindAsync(id);

            if (Assembling != null)
            {
                _context.Assembling.Remove(Assembling);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
