using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {
        //Eventos
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
<<<<<<< Updated upstream
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
=======
        Task<Evento[]> GetAllEventosByAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false);
>>>>>>> Stashed changes
    }
}