using campuslove.domain.ports;
using campusLove.domain.ports;

namespace campuslove.domain.factory
{
    public interface IDbFactory
    {
        IInteresRepository CreateInteresRepository();

        ICarreraRepository CreateCarreraRepository();

        IUsuarioRepository CreateUsuarioRepository();

        ISesionRepository CreateSesionRepository();

        ILikeRepository CreateLikeRepository();

        IMatchesRepository CreateMatchesRepository();

        IUsuarioInteresRepository CreateUsuarioInteresRepository();

        
    }
}