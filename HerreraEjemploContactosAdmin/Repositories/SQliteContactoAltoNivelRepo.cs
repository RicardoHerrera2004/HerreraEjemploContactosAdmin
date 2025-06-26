using HerreraEjemploContactosAdmin.Interfaces;
using HerreraEjemploContactosAdmin.Models;
using SQLite;

namespace HerreraEjemploContactosAdmin.Repositories
{
    public class SQliteContactoAltoNivelRepo : IContactService
    {
        public string _dbPath = FileSystem.AppDataDirectory + "/Contacto.db3";
        public SQLiteAsyncConnection _sqliteConnection;
        
        public SQliteContactoAltoNivelRepo()
        {
            Init(); 
        }

        public async void Init()
        {
            if (_sqliteConnection == null)
            {
                _sqliteConnection = new SQLiteAsyncConnection(_dbPath);
                await _sqliteConnection.CreateTableAsync<Contacto>();
            }           
            
        }

        public async Task<List<Contacto>> DevuelveListadoContactosAsync()
        {
            try
            {
                List<Contacto> contactos = await _sqliteConnection.Table<Contacto>().ToListAsync();
              
                return contactos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> GuardarContactoAsync(Contacto contacto)
        {
            try
            {
                int filasGuardadas = await _sqliteConnection.InsertAsync(contacto);
                if (filasGuardadas > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

                public async Task<bool> EliminarContactoAsync(int id)
        {
            try
            {
                int filasEliminadas = await _sqliteConnection.DeleteAsync(id);
                if (filasEliminadas > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
