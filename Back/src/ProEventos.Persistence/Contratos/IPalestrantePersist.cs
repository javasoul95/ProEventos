using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface IPalestrantePersist
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
<<<<<<< Updated upstream
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
=======
        Task<Palestrante[]> GetAllPalestrantesByAsync(bool includeEventos);
>>>>>>> Stashed changes
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);
    }
}