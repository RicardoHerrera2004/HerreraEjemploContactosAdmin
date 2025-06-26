
using SQLite;

namespace HerreraEjemploContactosAdmin.Models
{
    public class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Empresa { get; set; }

    }
}
