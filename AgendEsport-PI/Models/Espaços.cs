using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendEsport_PI.Models
{
    public class Espaços
    {
        [Required]     
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}