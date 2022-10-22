using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Turma
    {
        public string Curso { get; set; }

        public Turma(string curso)
        {
            Curso = curso;
        }
    }
}
