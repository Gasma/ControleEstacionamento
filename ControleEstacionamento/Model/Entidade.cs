using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstacionamento.Model
{
    public abstract class Entidade
    {
        public Entidade()
        {
            if (Id == Guid.Empty)
            {
                Id = Guid.NewGuid();
            }
        }

        public Guid Id { get; set; }
    }
}
