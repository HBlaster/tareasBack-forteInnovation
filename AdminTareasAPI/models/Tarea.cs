namespace AdminTareasAPI.models
{
    public enum EstadoTarea
    {
        Pendiente,
        EnProgreso,
        Completada
    }
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public EstadoTarea Estado { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
