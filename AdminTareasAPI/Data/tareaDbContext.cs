using Microsoft.EntityFrameworkCore;
using AdminTareasAPI.models;
using System.Threading;
namespace AdminTareasAPI.Data
{
        public class TaskDbContext : DbContext
        {
            public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

            public DbSet<Tarea> Tareas { get; set; }
        }
}
