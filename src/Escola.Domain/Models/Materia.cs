using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Materia
    {
        public string Nome { get; set; }

        public Materia(string nome)
        {
            Nome = nome;
        }
    }
}
