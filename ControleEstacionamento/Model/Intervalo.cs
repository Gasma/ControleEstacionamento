using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstacionamento.Model
{
    public class Intervalo : Entidade
    {
        public TimeSpan Minutos { get; set; }
        public decimal Valor { get; set; }
    }
}
