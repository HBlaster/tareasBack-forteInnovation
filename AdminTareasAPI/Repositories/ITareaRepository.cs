using AdminTareasAPI.models;

namespace AdminTareasAPI.Repositories
{
    public interface ITareaRepository
    {
        Task<IEnumerable<Tarea>> ObtenerTodas();
        Task<Tarea?> ObtenerPorId(int id);
        Task<Tarea> Crear(Tarea tarea);
        Task<Tarea?> Actualizar(int id, Tarea tarea);
        Task<bool> Eliminar(int id);
    }
}
