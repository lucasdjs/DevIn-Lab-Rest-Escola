using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class NotasMateria
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public int Nota { get; set; }
        public int BoletimId { get; set; }

        public NotasMateria(int id, int materia, int nota, int boletimId)
        {
            Id = id;
            MateriaId = materia;
            Nota = nota;
            BoletimId = boletimId;
        }
    }
}
