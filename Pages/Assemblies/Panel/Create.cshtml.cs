using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using XeonFun.Data;
using XeonFun.Models;

namespace XeonFun.Pages.Assemblies.Panel
{
    public class CreateModel : PageModel
    {
        private readonly XeonFun.Data.XeonFunContext _context;

        public CreateModel(XeonFun.Data.XeonFunContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Assembling Assembling { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Assembling.Add(Assembling);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
