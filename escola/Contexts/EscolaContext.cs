using escola.Models;
using Microsoft.EntityFrameworkCore;

namespace escola.Contexts
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("aluno");
            modelBuilder.Entity<Turma>().ToTable("turma");
        }

        // Definir comunicação com as tabela(s) do banco de dados
        public DbSet<Aluno> Contatos { get; set; }

        // Definir comunicação com as tabela(s) do banco de dados
        public DbSet<escola.Models.Turma>? Turma { get; set; }
        //public DbSet<Usuario> Usuario { get; set; }
    }
}
