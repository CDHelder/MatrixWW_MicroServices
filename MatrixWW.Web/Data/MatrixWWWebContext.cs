using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MatrixWW.Web.Models.Api;

namespace MatrixWW.Web.Data
{
    public class MatrixWWWebContext : DbContext
    {
        public MatrixWWWebContext (DbContextOptions<MatrixWWWebContext> options)
            : base(options)
        {
        }

        public DbSet<MatrixWW.Web.Models.Api.Product> Product { get; set; }
    }
}
