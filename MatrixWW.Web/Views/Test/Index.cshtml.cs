using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MatrixWW.Web.Data;
using MatrixWW.Web.Models.Api;

namespace MatrixWW.Web.Views.Test
{
    public class IndexModel : PageModel
    {
        private readonly MatrixWW.Web.Data.MatrixWWWebContext _context;

        public IndexModel(MatrixWW.Web.Data.MatrixWWWebContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
