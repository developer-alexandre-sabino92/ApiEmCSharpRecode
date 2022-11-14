using Microsoft.EntityFrameworkCore;
using ProjetoApi.Model;

namespace ProjetoApi.Database
{
    public class ClienteDbContext : DbContext
    {
       public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options) {

       }

       public DbSet <Cliente> Clientes { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)

        var cliente = modelBuilder.Entity<Cliente>();
        cliente.ToTable("clientes");
        cliente.HasKey(x => x.Id);
        cliente.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnnAdd();
        cliente.Property(x => x.Nome).HasColumnName("nome").IsRequired();
        cliente.Property(x => x.DataNascimento).HasColumnName("data_nascimento");
        
    }
}