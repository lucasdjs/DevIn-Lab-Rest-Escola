using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Domain.Models
{
    public class Boletim
    {
        public int Id { get; private set; }
        public int AlunoId { get; private set; }
        DateTime Date { get; set; }

        public Boletim(int id, int alunoId, DateTime date)
        {
            Id = id;
            AlunoId = alunoId;
            Date = date;
        }
    }
}
