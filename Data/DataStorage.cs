using DesafioEstagio.Models;

namespace DesafioEstagio.Data
{
    public static class DataStorage
    {
        public static List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>
        {
            new Colaborador { Id = 1, Nome = "Felipe (Futuro Estagiário)" },
            new Colaborador { Id = 2, Nome = "João da Silva" }
        };

        // Adicionamos 1 Workshop de teste
        public static List<Workshop> Workshops { get; set; } = new List<Workshop>
        {
            new Workshop { Id = 1, Nome = "Introdução ao C#", DataRealizacao = DateTime.Now, Descricao = "Aulão para os estagiários" }
        };

        // Adicionamos 1 Ata de teste: O Colaborador 1 (Felipe) participou do Workshop 1 (C#)
        public static List<AtaPresenca> Atas { get; set; } = new List<AtaPresenca>
        {
            new AtaPresenca { Id = 1, WorkshopId = 1, ColaboradorId = 1 }
        };

        public static int ProximoIdColaborador = 3;
        public static int ProximoIdWorkshop = 2;
        public static int ProximoIdAta = 2;
    }
}