using System.ComponentModel.DataAnnotations;

namespace BibliotecaDiegoAleman.Models.Domain
{
    public class Rol
    {
        [Key]

        public int PkRol {  get; set; }
        public string Nombre { get; set; }

    }
}
