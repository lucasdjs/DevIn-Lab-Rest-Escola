using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Infra.DataBase.Mappings
{
    internal class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("ALUNO");
            builder.HasKey(x => x.Id)
                .HasName("PK_AlunoId");

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .HasColumnType("uniqueidentifier");

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200); 
            
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Sobrenome)
                .HasColumnName("Sobrenome")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);


            builder.Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("DATE");

            builder.Property(x => x.Matricula)
            .HasColumnName("Matricula")
            .HasColumnType("int");



        }
    }
}
