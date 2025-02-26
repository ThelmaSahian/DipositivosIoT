using SensoresIoT.DispositivosIot.Domain.Models;

namespace SensoresIoT.DispositivosIot.Domain.IRepositories
{
    public interface IDispositivosIoTRepository
    {
        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        Task<List<Dispositivos>> GetDispositivosByIdTipo(int idTipo);

        /// <summary>
        /// Servicio para obtener los dispositivos por idTipo
        /// </summary>
        /// <param name="idTipo"></param>
        /// <returns></returns>
        Task<List<Dispositivos>> GetInformacionLimit(int idTipo, int limit);
    }
}
