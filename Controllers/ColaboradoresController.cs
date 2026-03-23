using Microsoft.AspNetCore.Mvc;
using DesafioEstagio.Models;
using DesafioEstagio.Data;

namespace DesafioEstagio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradoresController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(DataStorage.Colaboradores);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var colab = DataStorage.Colaboradores.FirstOrDefault(c => c.Id == id);
            if (colab == null) return NotFound("Colaborador não encontrado.");
            return Ok(colab);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Colaborador novoColaborador)
        {
            novoColaborador.Id = DataStorage.ProximoIdColaborador++;
            DataStorage.Colaboradores.Add(novoColaborador);
            return CreatedAtAction(nameof(GetById), new { id = novoColaborador.Id }, novoColaborador);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Colaborador colabAtualizado)
        {
            var index = DataStorage.Colaboradores.FindIndex(c => c.Id == id);
            if (index == -1) return NotFound("Colaborador não encontrado.");

            colabAtualizado.Id = id; // Garante que o ID não seja alterado
            DataStorage.Colaboradores[index] = colabAtualizado;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var colab = DataStorage.Colaboradores.FirstOrDefault(c => c.Id == id);
            if (colab == null) return NotFound("Colaborador não encontrado.");

            DataStorage.Colaboradores.Remove(colab);
            return NoContent();
        }
    }
}