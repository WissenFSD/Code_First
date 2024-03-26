using Code_First.DMO;
using Microsoft.EntityFrameworkCore;

namespace Code_First.Context
{
	public class DepartmentContext:DbContext
	{

        public DepartmentContext(DbContextOptions<DepartmentContext> options):base(options)
        {
            
        }

        // database'ê tabloları ekleyelim 
        public DbSet<HumanResource> HumanResources { get; set; }

    }
}
