using HerreraEjemploContactosAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerreraEjemploContactosAdmin.Interfaces
{
    interface IContactService
    {
        public void Init();
        public Task<List<Contacto>> DevuelveListadoContactosAsync();
        public Task<bool> GuardarContactoAsync(Contacto contacto);
        public Task<bool> EliminarContactoAsync(int id                                                                                                                                                          );
    }
}
