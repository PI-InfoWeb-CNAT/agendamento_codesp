using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgendEsport_PI.Models
{
    public class Agendamento
    {
        public int AgendamentoID { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data")]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime Data { get; set; }
        public AgendamentoHora Hora { get; set; }
        public AgendamentoQuadra Quadra { get; set; }
        public AgendamentoEsporte Esporte { get; set; }
    }

    public enum AgendamentoHora
    {
        Nove,
        Dez,
        Onze,
        Doze,
        Treze,
        Catorze,
        Quinze,
        Dezesseis,
        Dezessete
    }

    public enum AgendamentoQuadra
    {
        Q1,
        Q2,
        Q3,
        Ginásio
    }

    public enum AgendamentoEsporte
    {
        Futsal,
        Vôlei,
        Basquete,
        Handebol
    }
}