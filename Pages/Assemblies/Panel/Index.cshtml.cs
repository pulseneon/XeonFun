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
    public class IndexModel : PageModel
    {
        private readonly XeonFun.Data.XeonFunContext _context;

        public IndexModel(XeonFun.Data.XeonFunContext context)
        {
            _context = context;
        }

        public IList<Assembling> Assembling { get;set; }

        public async Task OnGetAsync()
        {
            Assembling = await _context.Assembling.ToListAsync();
        }
    }
}
