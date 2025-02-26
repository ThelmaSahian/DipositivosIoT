using Microsoft.EntityFrameworkCore;
using SensoresIoT.DispositivosIot.Domain.IRepositories;
using SensoresIoT.DispositivosIot.Domain.Models;
using SensoresIoT.Repositories;

namespace SensoresIoT.DispositivosIoT.Infrastructure.Repositories
{
    public class DispositivosIoTRepository : IDispositivosIoTRepository
    {
        private readonly DispositivosIoTContext _context;
        public DispositivosIoTRepository(DispositivosIoTContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        public async Task<List<Dispositivos>> GetDispositivosByIdTipo(int idTipo)
        {
            try
            {
                return await _context.Set<Dispositivos>().Where(x => x.IdTipo.Equals(idTipo)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        public async Task<List<Dispositivos>> GetInformacionLimit(int idTipo, int limit)
        {
            try
            {
                return await _context.Set<Dispositivos>().Where(x => x.IdTipo.Equals(idTipo)).Skip(0).Take(limit).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }
    }
}
