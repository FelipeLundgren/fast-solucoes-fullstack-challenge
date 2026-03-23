using Microsoft.AspNetCore.Mvc;
using DesafioEstagio.Models;
using DesafioEstagio.Data;

namespace DesafioEstagio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkshopsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(DataStorage.Workshops);

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var workshop = DataStorage.Workshops.FirstOrDefault(w => w.Id == id);
            if (workshop == null) return NotFound("Workshop não encontrado.");
            return Ok(workshop);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Workshop novoWorkshop)
        {
            novoWorkshop.Id = DataStorage.ProximoIdWorkshop++;
            DataStorage.Workshops.Add(novoWorkshop);
            return CreatedAtAction(nameof(GetById), new { id = novoWorkshop.Id }, novoWorkshop);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Workshop workshopAtualizado)
        {
            var index = DataStorage.Workshops.FindIndex(w => w.Id == id);
            if (index == -1) return NotFound("Workshop não encontrado.");

            workshopAtualizado.Id = id;
            DataStorage.Workshops[index] = workshopAtualizado;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var workshop = DataStorage.Workshops.FirstOrDefault(w => w.Id == id);
            if (workshop == null) return NotFound("Workshop não encontrado.");

            DataStorage.Workshops.Remove(workshop);
            return NoContent();
        }
    }
}