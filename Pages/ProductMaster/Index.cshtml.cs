using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud_razor_web_app.Context;
using crud_razor_web_app.Models;

namespace crud_razor_web_app.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly crud_razor_web_app.Context.AppDbContext _context;

        public IndexModel(crud_razor_web_app.Context.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
