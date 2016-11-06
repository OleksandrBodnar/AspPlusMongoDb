using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebAppTestMongoDb.Models
{
    public class ComputerContext
    {
        MongoClient client;
        IMongoDatabase database;
        MongoGridFS gridFS;

        public ComputerContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
            var con = new MongoUrlBuilder(connectionString);

            client = new MongoClient(connectionString);
            database = client.GetDatabase(con.DatabaseName);
            gridFS = new MongoGridFS(
                new MongoServer(
                    new MongoServerSettings { Server = con.Server }),
                con.DatabaseName,
                new MongoGridFSSettings()
            );
        }

        public IMongoCollection<Computer> Computers
        {
            get { return database.GetCollection<Computer>("Computers"); }
        }

        public MongoGridFS GridFS
        {
            get { return gridFS; }
        }
    }
}