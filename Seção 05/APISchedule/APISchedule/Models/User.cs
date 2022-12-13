using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APISchedule.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }
        public string? NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Senha { get; set; }

        [Required]
        [Compare("Senha")]
        public string? ConfirmarSenha { get; set; }
        
        public ICollection<Schedule>? Schedules { get; set; }
    }
}
