using DesafioEstagio.Models;

namespace DesafioEstagio.Data
{
    public static class DataStorage
    {
        // 1. Lista de Colaboradores (com nossos dados de teste)
        public static List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>
        {
            new Colaborador { Id = 1, Nome = "Felipe (Futuro Estagiário)" },
            new Colaborador { Id = 2, Nome = "João da Silva" }
        };

        // 2. Lista de Workshops
        public static List<Workshop> Workshops { get; set; } = new List<Workshop>();

        // 3. Lista de Atas (O QUE ESTAVA FALTANDO PARA O ERRO SUMIR!)
        public static List<AtaPresenca> Atas { get; set; } = new List<AtaPresenca>();

        // 4. Contadores para simular os IDs automáticos
        public static int ProximoIdColaborador = 3;
        public static int ProximoIdWorkshop = 1;
        public static int ProximoIdAta = 1; // Esse também estava faltando!
    }
}