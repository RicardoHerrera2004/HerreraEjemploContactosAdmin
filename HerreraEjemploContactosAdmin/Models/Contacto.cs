
using SQLite;

namespace HerreraEjemploContactosAdmin.Models
{
    [Table("ContactoFinal")]
    class Contacto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100), NotNull]
        public string Nombre { get; set; }

        [MaxLength(100), Unique]
        public string Correo { get; set; }

        [MaxLength(10), NotNull]
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Empresa { get; set; }

    }
}
