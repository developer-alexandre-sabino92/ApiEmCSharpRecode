

using Microsoft.EntityFrameworkCore;
using ProjetoApi.Database;
using ProjetoApi.Model;

namespace ProjetoApi.Repository
{
    public class ClienteRepository : IClienteRepository
    {   
        //Injetar dependencia do contexto
        private readonly ClienteDbContext _context;

        public ClienteRepository(ClienteDbContext context){
            _context = context;
        }

        public void AddCliente(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Update(cliente);
        }

        public void DeletarCliente(Cliente cliente)
        {
            _context.Remove(cliente);
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await _context.Clientes.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}