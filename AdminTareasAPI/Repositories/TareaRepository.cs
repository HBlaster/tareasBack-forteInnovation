using AdminTareasAPI.Data;
using AdminTareasAPI.models;
using Microsoft.EntityFrameworkCore;

namespace AdminTareasAPI.Repositories
{
    public class TareaRepository : ITareaRepository
    {
        private readonly TaskDbContext _context;

        public TareaRepository(TaskDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarea>> ObtenerTodas()
        {
            return await _context.Tareas.ToListAsync();
        }

        public async Task<Tarea?> ObtenerPorId(int id)
        {
            return await _context.Tareas.FindAsync(id);
        }

        public async Task<Tarea> Crear(Tarea tarea)
        {
            _context.Tareas.Add(tarea);
            await _context.SaveChangesAsync();
            return tarea;
        }

        public async Task<Tarea?> Actualizar(int id, Tarea tarea)
        {
            var existente = await _context.Tareas.FindAsync(id);
            if (existente == null) return null;

            existente.Titulo = tarea.Titulo;
            existente.Descripcion = tarea.Descripcion;
            existente.Estado = tarea.Estado;

            await _context.SaveChangesAsync();
            return existente;
        }

        public async Task<bool> Eliminar(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);
            if (tarea == null) return false;

            _context.Tareas.Remove(tarea);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
