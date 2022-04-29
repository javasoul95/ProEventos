using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contextos;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence
{
<<<<<<< Updated upstream
    public class EventoPersist : IEventoPersist
    {
        private readonly ProEventosContext _context;
        public EventoPersist(ProEventosContext context)
        {
            _context = context;
            //_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        
        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
=======
    public class EventoPersistence : IEventoPersist
    {
        private readonly ProEventosContext _context;
        public EventoPersistence(ProEventosContext context)
        {
            _context = context;
        }
        
        public async Task<Evento[]> GetAllEventosByAsync(bool includePalestrantes = false)
>>>>>>> Stashed changes
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(e => e.Lotes)
                .Include(e => e.RedeSociais);
            
            if (includePalestrantes)
            {
                query = query.Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

<<<<<<< Updated upstream
            query = query.AsNoTracking().OrderBy(e => e.Id);
=======
            query = query.OrderBy(e => e.Id);
>>>>>>> Stashed changes

            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(e => e.Lotes)
                .Include(e => e.RedeSociais);
            
            if (includePalestrantes)
            {
                query = query.Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

<<<<<<< Updated upstream
            query = query.AsNoTracking().OrderBy(e => e.Id)
=======
            query = query.OrderBy(e => e.Id)
>>>>>>> Stashed changes
                .Where(e => e.Tema.ToLower()
                .Contains(tema.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes)
        {
            IQueryable<Evento> query = _context.Eventos
                .Include(e => e.Lotes)
                .Include(e => e.RedeSociais);
            
            if (includePalestrantes)
            {
                query = query.Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
            }

<<<<<<< Updated upstream
            query = query.AsNoTracking().OrderBy(e => e.Id)
=======
            query = query.OrderBy(e => e.Id)
>>>>>>> Stashed changes
                .Where(e => e.Id == EventoId);

            return await query.FirstOrDefaultAsync();
        }
    }
}