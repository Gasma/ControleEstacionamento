using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstacionamento.Model
{
    public class Configuracao : Entidade
    {
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public IEnumerable<Intervalo> Intervalos { get; set; }
    }
}
