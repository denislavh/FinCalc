using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinCalc.Data
{
    public class FinCalcDbContext : IdentityDbContext
    {
        public FinCalcDbContext(DbContextOptions<FinCalcDbContext> options)
            : base(options)
        {
        }
    }
}
