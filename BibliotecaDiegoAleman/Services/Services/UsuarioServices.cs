using BibliotecaDiegoAleman.Context;
using BibliotecaDiegoAleman.Models.Domain;
using BibliotecaDiegoAleman.Services.IServices;

namespace BibliotecaDiegoAleman.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        
        private readonly ApplicationDbContext _context;
       public UsuarioServices(ApplicationDbContext context) 
       {
            _context = context;
            
       }

        public List<Usuario> ObtenerUsuario()
        {
            try
            {

                var result = _context.Usuarios.ToList();

                return result;
            }
            catch (Exception ex) 
            {

                throw new Exception("Sucedio un error"+ex.Message);
            }

               

        }

    }
}
