using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISchedule.Models
{
    public class Schedule
    {    
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime DataHora { get; set; }
        public string? Local { get; set; }
        public string? Descricao { get; set; }
        public string? Tipo { get; set; }
        public bool Concluido{ get; set; }
        public DateTime Criado { get; set; }    
        public User? User { get; set; }

    }
}
