using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class PersonasController
    {
        readonly SQLiteAsyncConnection _connection;

        public PersonasController()
        {
            SQLite.SQLiteOpenFlags extensiones=SQLite.SQLiteOpenFlags.ReadWrite
                | SQLite.SQLiteOpenFlags.ReadOnly | SQLite.SQLiteOpenFlags.Create
                | SQLite.SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory,
                "DBPersonas.db3"), extensiones);

            _connection.CreateTableAsync<Models.Personas>();
                        
        }
        //metodos crud

        public async Task<int> StorePerson(Models.Personas personas)
        {
            if (personas.Id == 0)
            {
                return await _connection.InsertAsync(personas);

            }
            else
            {
                return await _connection.UpdateAsync(personas);
            }
        }

        //read
        //update
        //delete

    }
}
