using Microsoft.EntityFrameworkCore;

namespace ExamenRecuperacion.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {


        }

        public DbSet<Profesor> Profesors { get; set; }
    }
}
