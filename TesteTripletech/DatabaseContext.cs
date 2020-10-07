using Microsoft.EntityFrameworkCore;
using TesteTripletech.Models;

public class DatabaseContext : DbContext
{
    public DbSet<Pessoa> pessoa { get; set; }
    public DbSet<Agendamento> agendamento { get; set; }
    public DbSet<PessoaAgendamento> pessoaagendamento { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=triple_sqlite.sqlite");
    }
}