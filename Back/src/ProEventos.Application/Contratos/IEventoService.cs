<<<<<<< Updated upstream
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace Back.src.ProEventos.Application.Contratos
>>>>>>> Stashed changes
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model); 
        Task<Evento> UpdateEventos(int eventoId, Evento model); 
        Task<bool> DeleteEventos(int eventoId); 
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