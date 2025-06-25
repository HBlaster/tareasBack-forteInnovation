using Microsoft.AspNetCore.Mvc;
using AdminTareasAPI.models;
using AdminTareasAPI.Repositories;

namespace AdminTareasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareasController : ControllerBase
    {
        private readonly ITareaRepository _repo;

        public TareasController(ITareaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetAll()
        {
            var tareas = await _repo.ObtenerTodas();
            return Ok(tareas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetById(int id)
        {
            var tarea = await _repo.ObtenerPorId(id);
            if (tarea == null) return NotFound();
            return Ok(tarea);
        }

        [HttpPost]
        public async Task<ActionResult<Tarea>> Crear([FromBody] Tarea tarea)
        {
            if (string.IsNullOrWhiteSpace(tarea.Titulo))
                return BadRequest("El título no puede estar vacío.");

            var nueva = await _repo.Crear(tarea);
            return CreatedAtAction(nameof(GetById), new { id = nueva.Id }, nueva);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Tarea>> Actualizar(int id, [FromBody] Tarea tarea)
        {
            var actualizada = await _repo.Actualizar(id, tarea);
            if (actualizada == null) return NotFound();
            return Ok(actualizada);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminado = await _repo.Eliminar(id);
            return eliminado ? NoContent() : NotFound();
        }
    }
}
