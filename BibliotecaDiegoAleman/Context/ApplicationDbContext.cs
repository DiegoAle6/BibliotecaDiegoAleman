using BibliotecaDiegoAleman.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDiegoAleman.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { } 

        //Modelos que se van a mapear en la BD
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    PkUsuario = 1,
                    Nombre = "Diego",
                    Apellido = "Aleman",
                    UserName = "Usuario",
                    Password = "123",
                    FkRol = 1,
                }
                );

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                PkRol = 1,
                Nombre = "Admin",
            });
        }
    }
}
