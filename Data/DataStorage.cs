using DesafioEstagio.Models;

namespace DesafioEstagio.Data
{
    public static class DataStorage
    {
        // Já iniciamos a lista com 2 colaboradores cadastrados!
        public static List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>
        {
            new Colaborador { Id = 1, Nome = "Felipe (Futuro Estagiário)" },
            new Colaborador { Id = 2, Nome = "João da Silva" }
        };

        public static List<Workshop> Workshops { get; set; } = new List<Workshop>();

        // Como já usamos o 1 e o 2, o próximo será o 3
        public static int ProximoIdColaborador = 3;
        public static int ProximoIdWorkshop = 1;
    }
}