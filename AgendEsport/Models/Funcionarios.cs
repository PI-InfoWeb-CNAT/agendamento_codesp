using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AgendEsport.Models
{
    
    public class Funcionarios
    {
        public long FuncionarioId { get; set; }
        public string Nome { get; set; }
    }
}

