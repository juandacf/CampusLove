using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using campuslove.domain.factory;
using campuslove.domain.ports;
using campuslove.infrastructure.repositories;
using campusLove.domain.ports;
using campusLove.infrastructure.repositories;
using CampusLove.domain.ports;


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

        public ILikeRepository CreateLikeRepository()
        {
            return new ImpLikeRepository(_connectionString);
        }

        public IMatchesRepository CreateMatchesRepository()
        {
            return new ImpMatchesRepository(_connectionString);
        }

        public ISesionRepository CreateSesionRepository()
        {
            return new ImpSesionRepository(_connectionString);
        }

        public IUsuarioRepository CreateUsuarioRepository()
        {
            return new ImpUsuarioRepository(_connectionString);
        }
    }
}