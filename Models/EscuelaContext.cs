using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> escuelas { get; set; }

        public DbSet<Alumno> alumnos { get; set; }
        public DbSet<Asignatura> asignaturas { get; set; }
        public DbSet<Curso>cursos{ get; set; }
        public DbSet<Evaluación> evaluaciones { get; set; }


        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options) { 
        
        
        
        
        }




    }
}
