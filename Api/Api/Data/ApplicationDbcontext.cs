using Api.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options): base(options) 
        
        {

            
        }
    

        public DbSet<Field> login { get; set; }
    }
   
}
