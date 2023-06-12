using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XeonFun.Data;
using XeonFun.Models;

namespace XeonFun.Pages.Assemblies.Panel
{
    public class EditModel : PageModel
    {
        private readonly XeonFun.Data.XeonFunContext _context;

        public EditModel(XeonFun.Data.XeonFunContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Assembling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssemblingExists(Assembling.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AssemblingExists(int id)
        {
            return _context.Assembling.Any(e => e.Id == id);
        }
    }
}
