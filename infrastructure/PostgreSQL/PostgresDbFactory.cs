using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.factory;
using campuslove.domain.ports;
using campuslove.infrastructure.repositories;

namespace campuslove.infrastructure.PostgreSQL
{
    public class PostgresDbFactory: IDbFactory
    {
        private readonly string _connectionString;
        public PostgresDbFactory(string connectionString){
            _connectionString = connectionString;
        }

        public ICarreraRepository CreateCarreraRepository()
        {
            return new ImpCarreraRepository(_connectionString);
        }

        public IInteresRepository CreateInteresRepository()
        {
            return new ImpInteresRepository(_connectionString);
        }
    }
}