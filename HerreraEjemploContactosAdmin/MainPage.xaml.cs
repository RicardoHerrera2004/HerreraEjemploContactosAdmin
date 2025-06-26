using HerreraEjemploContactosAdmin.Interfaces;
using HerreraEjemploContactosAdmin.Models;
using HerreraEjemploContactosAdmin.Repositories;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace HerreraEjemploContactosAdmin
{
    public partial class MainPage : ContentPage
    {
        IContactService _contactService;
        public MainPage()
        {
            InitializeComponent();
            _contactService = new SQliteContactoAltoNivelRepo();
            ObtenerListadoContactos();
        }
        // Evento para eliminar un contacto
        private async void GuardarBoton_Clicked(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto
            {
                Nombre = EntryNombre.Text,
                Correo = EntryCorreo.Text,
                Telefono = EntryTelefono.Text,
                Direccion = EntryDireccion.Text,
                Empresa = EntryEmpresa.Text
            };
            await _contactService.GuardarContactoAsync(contacto);
            ObtenerListadoContactos();
        }
        public async void ObtenerListadoContactos()
        {
            List<Contacto> contactos = await _contactService.DevuelveListadoContactosAsync();
            LabelContactos.Text = JsonConvert.SerializeObject(contactos);
        }
    }

}
