using Microsoft.AspNetCore.Mvc;
using DesafioEstagio.Models;
using DesafioEstagio.Data;

namespace DesafioEstagio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtasController : ControllerBase
    {
        // Registrar uma presença
        [HttpPost]
        public IActionResult RegistrarPresenca([FromBody] AtaPresenca ata)
        {
            // Valida se o workshop e o colaborador realmente existem
            var workshopExiste = DataStorage.Workshops.Any(w => w.Id == ata.WorkshopId);
            var colaboradorExiste = DataStorage.Colaboradores.Any(c => c.Id == ata.ColaboradorId);

            if (!workshopExiste) return NotFound("Workshop não encontrado.");
            if (!colaboradorExiste) return NotFound("Colaborador não encontrado.");

            // Salva a ata
            ata.Id = DataStorage.ProximoIdAta++;
            DataStorage.Atas.Add(ata);

            return Ok(new { Mensagem = "Presença registrada com sucesso!", Ata = ata });
        }

        // Listar presenças de um workshop específico
        [HttpGet("workshop/{workshopId}")]
        public IActionResult GetPresencasPorWorkshop(int workshopId)
        {
            var presencas = DataStorage.Atas.Where(a => a.WorkshopId == workshopId).ToList();

            // Isso aqui é um bônus: junta os dados para mostrar os nomes em vez de só os IDs
            var resultado = presencas.Select(p => new {
                Workshop = DataStorage.Workshops.First(w => w.Id == p.WorkshopId).Nome,
                Colaborador = DataStorage.Colaboradores.First(c => c.Id == p.ColaboradorId).Nome
            });

            return Ok(resultado);
        }
    }
}