using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.DTO;
using Escola.Domain.Models;
using Escola.Domain.Interfaces.Repositories;
using Escola.Domain.Interfaces.Services;

namespace Escola.Domain.Services
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public void Excluir(AlunoDTO aluno)
        {
            throw new NotImplementedException();
        }

        public void Inserir(AlunoDTO aluno)
        {
            //ToDo: Validar se já consta matricula.

            _alunoRepositorio.Inserir(new Aluno(aluno));
        }

        public AlunoDTO ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<AlunoDTO> ObterTodos()
        {
            //var alunoResposta= new List<AlunoDTO>();
            //var alunos = _alunoRepositorio.ObterTodos();
            //foreach (var Alunos in alunos)
            //{
            //    alunoResposta.Add(new AlunoDTO(aluno));
            //}
            return _alunoRepositorio.ObterTodos()
                .Select(x => new AlunoDTO(x)).ToList();
        }
    }
}