using DesafioEstagio.Models;

namespace DesafioEstagio.Data
{
    public static class DataStorage
    {
        // Listas que vão guardar os dados enquanto a API estiver rodando
        public static List<Colaborador> Colaboradores { get; set; } = new List<Colaborador>();
        public static List<Workshop> Workshops { get; set; } = new List<Workshop>();

        // Contadores para simular o ID automático do banco de dados
        public static int ProximoIdColaborador = 1;
        public static int ProximoIdWorkshop = 1;
    }
}