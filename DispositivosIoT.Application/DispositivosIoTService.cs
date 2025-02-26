using Dipositivos.DispositivosIoT.Application.Enumerables;
using SensoresIoT.DispositivosIot.Domain.IRepositories;
using SensoresIoT.DispositivosIot.Domain.Models;

namespace Dipositivos.DispositivosIoT.Application
{
    public class DispositivosIoTService : IDispositivosIoTService
    {
        private readonly IDispositivosIoTRepository _dispositivosIoTRepository;

        public DispositivosIoTService(IDispositivosIoTRepository dispositivosIoTRepository)
        {
            _dispositivosIoTRepository = dispositivosIoTRepository;
        }

        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        public async Task<List<Dispositivos>> GetDispositivosByIdTipo(int idTipo)
        {
            return await _dispositivosIoTRepository.GetDispositivosByIdTipo(idTipo);
        }

        /// <summary>
        /// Servicio para obtener la información de los sensores
        /// </summary>
        /// <returns></returns>
        public async Task<List<Dispositivos>> GetInformation()
        {
            int idTipo = (int)TiposDispositivos.Sensores;
            return await GetDispositivosByIdTipo(idTipo);
        }

        /// <summary>
        /// Servicio para obtener la información de los sensores
        /// </summary>
        /// <returns></returns>
        public async Task<List<Dispositivos>> GetInformacionLimit(int limit)
        {
            int idTipo = (int)TiposDispositivos.Sensores;
            return await _dispositivosIoTRepository.GetInformacionLimit(idTipo, limit);
        }
    }
}
