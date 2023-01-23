using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendEsport_PI.Models
{
    public class Funcionarios
    {
        [Required] public int Id { get; set; }

        [Required, StringLength(16)] 
        public string Registro { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

    }
}