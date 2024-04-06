using Microsoft.EntityFrameworkCore;

namespace L01P02_2021MR602.Models
{
    public class NotasContext:DbContext
    {
        public NotasContext(DbContextOptions<NotasContext> options) : base(options)
        {



        }
        public DbSet<Materias> materias { get; set; }
        public DbSet<Departamentos> departamentos { get; set; }
        public DbSet<Facultades> facultades { get; set; }
        public DbSet<Alumnos> alumnos { get; set; }

    }

}
