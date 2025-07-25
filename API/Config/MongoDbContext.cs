﻿using MongoDB.Driver;
using API.Models;
using System.Diagnostics;
using API.Utils;

namespace API.Config
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(MongoDbSettings settings)
        {
            try
            {
                var client = new MongoClient(settings.ConnectionString);

                // 🔁 Forzar una llamada para validar la conexión
                client.ListDatabaseNames();  // <-- esto lanza error si no conecta

                Log.Debugg("Conectado correctamente a MongoDB");

                _database = client.GetDatabase(settings.DatabaseName);
            }
            catch (Exception ex)
            {
                Log.Debugg($"❌ Error al conectar a MongoDB:{ex.Message}");
                throw; // <-- relanza el error para que la app falle si no hay conexión
            }
        }

        public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");

    }
}
