using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebNotas.Models
{
    public class WebNotasContext : DbContext
    {
        public WebNotasContext(DbContextOptions<WebNotasContext>options) : base(options)
        {
            
        }

        public virtual DbSet<Nota> Notas { get; set; }
    }
}
